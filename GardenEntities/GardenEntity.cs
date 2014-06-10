using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenEntities
{
    public class GardenEntity
    {
        public string name { get; set; }
        public string description { get; set; }
        public string maintenance { get; set; }
        public plantType type { get; set; }
        public sunExposure lightExposure { get; set; }
        public hardinessZone coldestHardiness { get; set; }
        public hardinessZone hottestHardiness { get; set; }
        public List<Month> seedStartMonths { get; set; }

        public enum plantType { annual, perenial }
        public enum sunExposure { full_shade, partial_shade, full_sun }
        public enum hardinessZone
        { zero, one, two, three, four, five, six, seven, eight, nine, ten, eleven }
        public enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
    }
}
