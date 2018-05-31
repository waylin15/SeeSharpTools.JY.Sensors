using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JY.UnitConversion;

namespace Sensor
{
    class LoadCell
    {
        private double _rMax;
        private double _rMin;
        private double _loadMax;
        private double _loadMin;

        public LoadCell(double rMax, double rMin, double loadMax, double loadMin)
        {
            this._rMax = rMax;
            this._rMin = rMin;
            this._loadMax = loadMax;
            this._loadMin = loadMin;
        }

        public double Convert(double voltage, double referenceR, double stirVoltage)
        {
            return Conversion.Weight(voltage, stirVoltage, referenceR, _loadMax, _rMin, _rMax, "kg");
        }

        public double[] Convert(double[] voltages, double referenceR, double stirVoltage)
        {
            return Conversion.Weight(voltages, stirVoltage, referenceR, _loadMax, _rMin, _rMax, "kg");
        }
    }

}
