using System;

namespace Theta {
    class Utilities {
        public static double Theta(double x, double a, double buf_max = 80, int k_max = 500) {
            double sum, buf, xx, buf2, q;
            int k;
            if (a < 1 / Math.PI) {
                sum = 1;
                k = 0;
                do {
                    k++;
                    buf = (k * k) / (2 * a * a);
                    sum += 2 * Math.Exp(-buf) * Math.Cos(2 * k * x);
                } while ((buf < buf_max) && (k < k_max));
                return sum;
            } else {
                k = (int)Math.Round(x / (2 * Math.PI));
                xx = x - 2 * k * Math.PI;
                sum = Math.Exp(-(a * a * xx * xx) * 2);
                k = 0;
                do
                {
                    k++;
                    buf = (a * Math.Pow(xx + 2 * Math.PI * k, 2));
                    buf2 = (a * Math.Pow(xx - 2 * Math.PI * k, 2));
                    sum += Math.Exp(-buf) + Math.Exp(-buf2);
                } while (((buf < buf_max) || (buf2 < buf_max)) && (k < k_max));

                return Math.Sqrt(2 * Math.PI) * a * sum;
            }
        }

        private static double mz_ini(double a, int maxBuff = 80) {
            double mul;
            if (a < 1 / Math.PI)
                mul = 1 / a;
            else
                mul = Math.Pow(Math.PI, 2) * a;
            double sum = Math.Exp(-mul / 4);
            int r = 0;
            double buff;
            do
            {
                r++;
                buff = mul * Math.Pow(-2 * r + 0.5, 2);
                sum += (-4 * r + 1) * Math.Exp(-buff);
                buff = mul * Math.Pow(2 * r + 0.5, 2);
                sum += (4 * r + 1) * Math.Exp(-buff);
            } while (buff < maxBuff);
            if (a < 1 / Math.PI)
                return sum;
            else
                return sum * Math.PI * a * Math.Sqrt(Math.PI * a);
        }


        public static double[] CalcCoeffs(double a, int coeffCount, int maxBuff = 80) {
            double c_a = Utilities.mz_ini(a);
            double[] c = new double[coeffCount];
            double buff;
            for (int k = 0; k < coeffCount; k++) {
                int sign = k % 2 == 0 ? -1 : 1;
                double sum = 0;
                int r = k - 1;
                do {
                    sign = -sign;
                    r++;
                    buff = ((r + 0.5 + k) * (r + 0.5 - k)) / a;
                    sum += sign * Math.Exp(-buff);
                } while (buff < maxBuff);
                c[k] = sum / c_a;
            }
            return c;
        }

        public static double dual(double x, double omega1, double omega2, int k_cnt = 30) {
            var buf = 4 / Math.Pow(omega1, 2);
            double[] c_k = Utilities.CalcCoeffs(buf, k_cnt);

            double sum1 = c_k[0] * Math.Exp(-Math.Pow(x, 2) / 2);
            for (int k = 1; k < k_cnt; k++) {
                sum1 += c_k[k] * Math.Exp(-Math.Pow(x - k * omega1, 2) / 2) +
                c_k[k] * Math.Exp(-Math.Pow(x + k * omega1, 2) / 2);
            }
            double sum2 = 1 / Theta((omega2 * x) / 2, Math.Exp(-(Math.Pow(omega2, 2) / 4)));
            buf = (sum1 * sum2) / (2 * Math.Sqrt(Math.PI));

            return buf;
        }

    }
}
