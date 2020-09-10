using System;
using System.Collections.Generic;
using System.Text;

namespace GatewayPortal.PACS.Model
{
    class AnonymizeDataModel
    {
        public string PatientName { get; set; }
        public string PatientID { get; set; }
        public string PatientBirthDate { get; set; }
        public string PatientSex { get; set; }
        public string PatientAge { get; set; }
        public string PatientWeight { get; set; }
        public string PatientAddress { get; set; }
        public DateTime StudyDate { get; set; }
        public DateTime StudyTime { get; set; }
        public string StudyID { get; set; }
        public string StudyModality { get; set; }
        public string StudyDescription { get; set; }
        public DateTime SeriesDate { get; set; }
        public DateTime SeriesTime { get; set; }
        public string SeriesDescription { get; set; }
        public string AccessionNumber { get; set; }
        public string InstitutionName { get; set; }

    }
}
