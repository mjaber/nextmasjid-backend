using System;
namespace PolygonArrangements
{
    public class Mosque
    {
        public string ObjectID { get; set; }
        public string ObjectCode { get; set; }
        public string NationalCode { get; set; }
        public string MosqueID { get; set; }
        public string MosqueName { get; set; }
        public string Region { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string MailAddress { get; set; }
        public string MinistrySubordinate { get; set; }
        public string MosqueCategory { get; set; }
        public bool HasImamHouse { get; set; }
        public bool HasMoathenHouse { get; set; }
        public bool HasServantHouse { get; set; }
        public string MosqueStatus { get; set; }
        public string Parking { get; set; }
        public string WaterMeterAvailability { get; set; }
        public string WaterMeterCode { get; set; }
        public string ElectricityMeterAvailability { get; set; }
        public string ElecticityMeterCode { get; set; }
        public string SanitationAvailability { get; set; }
        public bool AsphaltRoad { get; set; }
        public string Surrounding { get; set; }
        public string ConstructionDate { get; set; }
        public string MosqueSize { get; set; }
        public string DeedNumber { get; set; }
        public string DeedDate { get; set; }
        public string DeedSource { get; set; }

        public string ImamName { get; set; }
        public string ImamEmployeeNumber { get; set; }
        public string ImamNationalID { get; set; }
        public string ImamNationality { get; set; }
        public string ImamBirthPlace { get; set; }
        public string ImamAppointmentDate { get; set; }
        public string ImamQualification { get; set; }
        public string ImamGraduationInstitute { get; set; }
        public string ImamGraduationYear { get; set; }
        public string ImamGrduationPlace { get; set; }
        public string ImamMobileNumber { get; set; }
        public string ImamMobileNumberOther { get; set; }

        public string KhateebName { get; set; }
        public string KhateebEmployeeNumber { get; set; }
        public string KhateebNationalID { get; set; }
        public string KhateebNationality { get; set; }
        public string KhateebBirthPlace { get; set; }
        public string KhateebAppointmentDate { get; set; }
        public string KhateebQualification { get; set; }
        public string KhateebGraduationInstitute { get; set; }
        public string KhateebGraduationYear { get; set; }
        public string KhateebGrduationPlace { get; set; }
        public string KhateebMobileNumber { get; set; }
        public string KhateebMobileNumberOther { get; set; }

        public string MoathenName { get; set; }
        public string MoathenEmployeeNumber { get; set; }
        public string MoathenNationalID { get; set; }
        public string MoathenNationality { get; set; }
        public string MoathenBirthPlace { get; set; }
        public string MoathenAppointmentDate { get; set; }
        public string MoathenQualification { get; set; }
        public string MoathenGraduationInstitute { get; set; }
        public string MoathenGraduationYear { get; set; }
        public string MoathenGrduationPlace { get; set; }
        public string MoathenMobileNumber { get; set; }
        public string MoathenMobileNumberOther { get; set; }


        public string ServantName { get; set; }
        public string ServantEmployeeNumber { get; set; }
        public string ServantNationalID { get; set; }
        public string ServantNationality { get; set; }
        public string ServantBirthPlace { get; set; }
        public string ServantAppointmentDate { get; set; }
        public string ServantQualification { get; set; }
        public string ServantGraduationInstitute { get; set; }
        public string ServantGraduationYear { get; set; }
        public string ServantGrduationPlace { get; set; }
        public string ServantMobileNumber { get; set; }
        public string ServantMobileNumberOther { get; set; }


        public string ObserverName { get; set; }
        public string ObserverEmployeeNumber { get; set; }
        public string ObserverNationalID { get; set; }
        public string ObserverNationality { get; set; }
        public string ObserverBirthPlace { get; set; }
        public string ObserverAppointmentDate { get; set; }
        public string ObserverQualification { get; set; }
        public string ObserverGraduationInstitute { get; set; }
        public string ObserverGraduationYear { get; set; }
        public string ObserverGrduationPlace { get; set; }
        public string ObserverMobileNumber { get; set; }
        public string ObserverMobileNumberOther { get; set; }


        //"Imam_Nationality":"<Null>","Imam_Birth_Date":"<Null>","Imam_Birth_Place":"<Null>","Imam_Appointment_Date":"<Null>",
        //"Imam_Qualification":"<Null>","Imam_Graduation_Institute":"<Null>","Imam_Graduation_Year":"<Null>","Imam_Graduation_Place":"<Null>",
        //"Imam_Mobile_No":"<Null>","Imam_Mobile_No_Other":"<Null>",
        //"Khateeb_Name":null,"Khateeb_Employee_No":null,"Khateeb_ID_No":null,"Khateeb_Nationality":"<Null>","Khateeb_Birth_Date":"<Null>","Khateeb_Birth_Place":"<Null>","Khateeb_Appointment_Date":"<Null>","Khateeb_Qualification":"<Null>","Khateeb_Graduation_Institute":"<Null>","Khateeb_Graduation_Year":"<Null>","Khateeb_Graduation_Place":"<Null>","Khateeb_Mobile_No":null,"Khateeb_Mobile_No_other":"<Null>",
        //"Moathen_Name":null,"Moathen_Employee_No":null,"Moathen_ID_No":null,"Moathen_Nationality":"<Null>","Moathen_Birth_Date":"<Null>","Moathen_Birth_Place":"<Null>","Moathen_Appointment_Date":"<Null>","Moathen_Qualification":"<Null>","Moathen_Graduation_Institute":"<Null>","Moathen_Graduation_Year":"<Null>","Moathen_Graduation_Place":"<Null>","Moathen_Mobile_No":null,"Moathen_Mobile_No_Other":"<Null>",
        //"Servant_Name":null,"Servant_Employee_No":null,"Servant_ID_No":null,"Servant_Nationality":"<Null>","Servant_Birth_Date":"<Null>","Servant_Birth_Place":"<Null>","Servant_Appointment_Date":"<Null>","Servant_Qualification":"<Null>","Servant_Graduation_Institute":"<Null>","Servant_Graduation_Year":"<Null>","Servant_Graduation_Place":"<Null>","Servant_Mobile_No":null,"Servant_Mobile_No_Other":"<Null>",
        //"Observer_Name":null,"Observer_Employee_No":null,"Observer_ID_No":null,"Observer_Nationality":"<Null>","Observer_Birth_Date":"<Null>","Observer_Birth_Place":"<Null>","Observer_Appointment_Date":"<Null>","Observal_Qualification":"<Null>","Observal_Graduation_Institute":"<Null>","Observer_Graduation_Place":"<Null>","Observal_Graduation_Year":"<Null>","Observer_Mobile_No":null,"Observer_Mobile_No_other":"<Null>",


        public string ConstructionType { get; set; }
        public string MosqueMaintenance { get; set; }
        public string MosqueMaintenanceDate { get; set; }
        public string MosqueMaintenanceRoofStatus { get; set; }
        public string MosqueMaintenanceExternalPaintStatus { get; set; }
        public string MosqueMaintenanceInternalPaintStatus { get; set; }
        public string MosqueMaintenanceDoorStatus { get; set; }
        public string MosqueMaintenanceWindowsStatus { get; set; }
        public string MosqueMaintenanceColumnStatus { get; set; }

        //"Construction_Type":1,"Mosque_Maintenance":0,"Maintenance_Date":"<Null>","Roof_Status":4,"External_Paint_Status":4,
        //"Internal_Paint_Status":4,"Doors_Status":4,"Windows_Status":4,"Cracks_Column":0,"Cracks_Column_Kamar":0,"Cracks_Wall":0,"Cracks_Sotra":0,"Crack_Instructive":0,"Crack_stairs":0,"Crack_extension":0,"Floor_Subsidence":0,"Sidewalk_Subsidence":0,"Courtyard_Subsidence":0,"Water_Leak_Floor":0,"Water_Leak_SideWalk":0,"Water_Leak_Courtyard":0,"Bathrooms_No":null,"Airconditioners_No":null,"Airconditioners_Type":5,"Maintenance_Contract":0,"Maintenance_Contractor":"<Null>","Lighting_Status":4,"Plumbering_Status":4,"Electrical_Wiring_Status":4,"Fans_Status":4,"Airconditioners_Status":4,"Ablution_Places_Status":4,"Ablution_Places_Type":4,"Ablution_Places_No":null,"Health_Articles":4,"Bathrooms_Status":4,"Water_Coolers_Status":4,"Carpets_Status":4,"Microfons_Status":4,

        //public Coordinate Geometry { get; set; }
        //"Easting":"36.227310925","Northing":"29.048368522","Zone_":37,"Notes":null,"MosqueNationalCode":"07-00443","RegionC":7,"ProvienceC":0,"MosqueID":"67699"},"geometry":{"x":4032805.804980601,"y":3381803.7055192757}}

       

    }

    public class Coordinate
    {
        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
