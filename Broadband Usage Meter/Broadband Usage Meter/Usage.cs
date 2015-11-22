using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Broadband_Usage_Meter
{
    [DataContract]
    internal class Usage
    {
        internal const double GigabyteInBytes = 1073741824;
        internal const double Multiplier = 10;


        [DataMember]
        internal double downlink;

        [DataMember]
        internal double uplink;

        [DataMember]
        internal double totalfup;

        [DataMember]
        internal double totalrem;

        [DataMember]
        internal double peakfup;

        [DataMember]
        internal double peakrem;

        public double RemainingPeakData
        {
            get
            {
                return Math.Round(peakrem / GigabyteInBytes * Multiplier) / Multiplier;
            }
        }

        public double RemainingTotalData
        {
            get
            {
                return Math.Round(totalrem / GigabyteInBytes * Multiplier) / Multiplier;
            }
        }

        public int RemainingTotalDataPercentage
        {
            get
            {
                double totalRemaining = 100 - totalfup;
                return (int)Math.Round(totalRemaining);
            }
        }

        public int RemainingPeakDataPercentage
        {
            get
            {
                double peakRemaining = 100 - peakfup;
                return (int)Math.Round(peakRemaining);
            }
        }

        /*
        [DataMember]
        internal double totalData;

        [DataMember]
        internal double remainingTotalData;

        [DataMember]
        internal double totalPeakData;

        [DataMember]
        internal double remainingPeakData;
        */
    }
}
