using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;

namespace SignalsAndSpectrums
{
    class SpectralCalculator
    {
        float v;
        float x;
        float q;
        float fDom;
        float dt;
        float df;

        float T;
        float F;
        float[] times;
        float[] frequencies;

        float[] signal;
        Complex32[] spectrum;
        float[] spectrumMagnitude;
        float[] spectrumPhase;
        float[] spectruMagnitudeQ;
        float[] signalQ;

        public SpectralCalculator(float df, float dt, float v, float x, float q, float fDom)
        {
            this.dt = dt;
            this.df = df;
            this.v = v;
            this.q = q;
            this.fDom = fDom;
            this.x = x;

            T = 1 / df;
            F = 1 / dt;

            times = fillArray(-T / 2, T / 2, dt);
            frequencies = fillArray(0, F, df);
            signal = Ricker(fDom, times);

            //spectrum calculation
            spectrum = ReToComplex(signal);
            //ApplyHamming(ref spectrum);
            Fourier.Forward(spectrum, FourierOptions.Matlab);

            spectrumMagnitude = GetMagnitude(spectrum);
            spectruMagnitudeQ = AttenuatedAmplitude(spectrumMagnitude, df, x, v, q);
            spectrumPhase = GetAngle(spectrum);

            Complex32[] tmp = AmpFiToComplex(spectruMagnitudeQ, spectrumPhase);//new float[spectruMagnitudeQ.Length]);
            //ApplyHamming(ref tmp);
            Fourier.Inverse(tmp,FourierOptions.Matlab);
            signalQ = GetReal(tmp);

            spectruMagnitudeQ = Normalized(spectruMagnitudeQ, SpectrumMagnitude.Max());
            spectrumMagnitude = Normalized(SpectrumMagnitude);
        }

        private float[] Ricker(float fDom, float[]t)
        {
            float[] s = new float[t.Length];
            float calcConst = -(float)Math.PI * (float)Math.PI * fDom * fDom;
            for (int k = 0; k < s.Length; k++)
            {
                float t2 = t[k] * t[k];
                s[k] = (1 + 2 * t2 * calcConst) * (float)Math.Exp(calcConst * t2);
            }

            return s;
        }

        private void ApplyHamming(ref Complex32[]array)
        {
            double[] wnd = MathNet.Numerics.Window.HammingPeriodic(signal.Length);
            for(int i=0;i<array.Length;i++)
                array[i] *= (float)wnd[i];
        }

        private Complex32[] ReToComplex(float[] real)
        {
            Complex32[] res = new Complex32[real.Length];
            for (int i = 0, n = real.Length; i < n; i++)
                res[i] = new Complex32(real[i], 0);
            return res;
        }

        private Complex32[] ReImToComplex(float[] real, float[] imag)
        {
            Complex32[] res = new Complex32[real.Length];
            for(int i =0;i<real.Length;i++)
                res[i] = new Complex32(real[i], imag[i]);
            return res;
        }

        private Complex32[] AmpFiToComplex(float[]mag,float[]fi)
        {
            Complex32[] res = new Complex32[mag.Length];
            for(int i =0;i<res.Length;i++)
            {
                res[i] = mag[i] * MathNet.Numerics.Complex32.Exp(new Complex32(0, fi[i]));
            }
            return res;
        }

        private float[] GetReal(Complex32[] array)
        {
            float[] real=new float[array.Length];
            for (int i = 0; i < array.Length; i++)
                real[i] = array[i].Real;
            return real;
        }

        private float[] GetMagnitude(Complex32[] array)
        {
            float[] magnitude = new float[array.Length];
            for(int i =0; i<magnitude.Length;i++)
                magnitude[i] = array[i].Magnitude;
            return magnitude;
        }

        private float[] GetAngle(Complex32[] array)
        {
            float[] res = new float[array.Length];
            for(int i =0;i<array.Length;i++)
            {
                res[i] = array[i].Phase;
            }
            return res;
        }

        private float[] AttenuatedAmplitude(float[] amplitude, float df, float x, float v, float q)
        {
            int nsmp = amplitude.Length;
            int nsmp1 = nsmp-1;
            float[] res = new float[nsmp];
            int halfLength = amplitude.Length / 2;
            double calcConst = -Math.PI * df * x / v / q;
            for (int i = 0; i < halfLength; i++)
            {
                res[i] = amplitude[i] * (float)Math.Exp(calcConst * i);
                res[nsmp1 - i] = res[i];
            }
            if(res.Length%2!=0)
                res[halfLength]= amplitude[halfLength] * (float)Math.Exp((halfLength - 1)*calcConst);
            return res;
        }

        // возвращает заполненный массив данных
        private float[] fillArray(float min, float max, float step)
        {
            int nsmp = Convert.ToInt32((max - min) / step)+1;
            float[] t = new float[nsmp];
            for (int k = 0; k < nsmp; k++)
                t[k] = min + step * k;
            return t;
        }

        private float[] Normalized(float[] array)
        {
            float max = Math.Abs(array.Max());
            var length = array.Length;
            for (var i = 0; i < length; i++)
                array[i] /= max;
            return array;
        }

        private float[] Normalized(float[] array, float max)
        {
            var length = array.Length;
            for (var i = 0; i < length; i++)
                array[i] /= max;
            return array;
        }

        public float[] Signal { get { return signal; } }
        public float[] SignalQ { get { return signalQ; } }
        public float[] SpectrumMagnitude { get { return spectrumMagnitude; } }
        public float[] SpectrumMagnitudeQ { get { return spectruMagnitudeQ; } }
        public float[] Times { get { return times; } }
        public float[] Frequencies { get { return frequencies; } }
    }
}
