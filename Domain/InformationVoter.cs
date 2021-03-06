using System;
using Inter.MixAN.Repository;

namespace Inter.MixAN.Domain
{
    public class InformationVoter : IIdentifier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PassportSeriesAndNumber { get; set; }

        public InformationVoter(int id, string name, int passportSeriesAndNumber)
        {
            Id = id;
            Name = name;
            PassportSeriesAndNumber = passportSeriesAndNumber;
        }
    }
}