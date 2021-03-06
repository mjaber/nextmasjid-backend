﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IbnMasjjed.DomainView
{
    public class MosqueView
    {
        public long Id { get; set; }
        public Nullable<long> ObjectID { get; set; }
        public string code { get; set; }
        public Nullable<long> Region { get; set; }
        public int? ProvinceId { get; set; }
        public string Province { get; set; }
        public string City_Village { get; set; }
        public string District { get; set; }
        public string Street_Name { get; set; }
        public string Mail_Address { get; set; }
        public string Ministry_Subordinate { get; set; }
        public string Mosque_Name { get; set; }
        public Nullable<long> Mosque_Catogery { get; set; }
        public Nullable<long> Imam_House { get; set; }
        public Nullable<long> Moathen_House { get; set; }
        public Nullable<long> Servant_House { get; set; }
        public Nullable<long> Mosque_Status { get; set; }
        public Nullable<long> Parking { get; set; }
        public Nullable<long> Water_Meter_Avilability { get; set; }
        public string Water_Meter { get; set; }
        public Nullable<long> Electrcity_Meter_Avilability { get; set; }
        public string Electrcity_Meter { get; set; }
        public Nullable<long> Sanitation_Avilability { get; set; }
        public Nullable<long> Asphalt_Road { get; set; }
        public Nullable<long> Mosque_Surrounding { get; set; }
        public string Constructing_Date { get; set; }
        public string Mosque_Size { get; set; }
        public string Deed_No { get; set; }
        public string Deed_Date { get; set; }
        public string Deed_Source { get; set; }
        public string Imam_Name { get; set; }
        public string Imam_Employee_No { get; set; }
        public string Imam_ID_No { get; set; }
        public string Imam_Nationality { get; set; }
        public string Imam_Birth_Date { get; set; }
        public string Imam_Birth_Place { get; set; }
        public string Imam_Appointment_Date { get; set; }
        public string Imam_Qualification { get; set; }
        public string Imam_Graduation_Institute { get; set; }
        public string Imam_Graduation_Year { get; set; }
        public string Imam_Graduation_Place { get; set; }
        public string Imam_Mobile_No { get; set; }
        public string Imam_Mobile_No_Other { get; set; }
        public string Khateeb_Name { get; set; }
        public string Khateeb_Employee_No { get; set; }
        public string Khateeb_ID_No { get; set; }
        public string Khateeb_Nationality { get; set; }
        public string Khateeb_Birth_Date { get; set; }
        public string Khateeb_Birth_Place { get; set; }
        public string Khateeb_Appointment_Date { get; set; }
        public string Khateeb_Qualification { get; set; }
        public string Khateeb_Graduation_Institute { get; set; }
        public string Khateeb_Graduation_Year { get; set; }
        public string Khateeb_Graduation_Place { get; set; }
        public string Khateeb_Mobile_No { get; set; }
        public string Khateeb_Mobile_No_other { get; set; }
        public string Moathen_Name { get; set; }
        public string Moathen_Employee_No { get; set; }
        public string Moathen_ID_No { get; set; }
        public string Moathen_Nationality { get; set; }
        public string Moathen_Birth_Date { get; set; }
        public string Moathen_Birth_Place { get; set; }
        public string Moathen_Appointment_Date { get; set; }
        public string Moathen_Qualification { get; set; }
        public string Moathen_Graduation_Institute { get; set; }
        public string Moathen_Graduation_Year { get; set; }
        public string Moathen_Graduation_Place { get; set; }
        public string Moathen_Mobile_No { get; set; }
        public string Moathen_Mobile_No_Other { get; set; }
        public string Servant_Name { get; set; }
        public string Servant_Employee_No { get; set; }
        public string Servant_ID_No { get; set; }
        public string Servant_Nationality { get; set; }
        public string Servant_Birth_Date { get; set; }
        public string Servant_Birth_Place { get; set; }
        public string Servant_Appointment_Date { get; set; }
        public string Servant_Qualification { get; set; }
        public string Servant_Graduation_Institute { get; set; }
        public string Servant_Graduation_Year { get; set; }
        public string Servant_Graduation_Place { get; set; }
        public string Servant_Mobile_No { get; set; }
        public string Servant_Mobile_No_Other { get; set; }
        public string Observer_Name { get; set; }
        public string Observer_Employee_No { get; set; }
        public string Observer_ID_No { get; set; }
        public string Observer_Nationality { get; set; }
        public string Observer_Birth_Date { get; set; }
        public string Observer_Birth_Place { get; set; }
        public string Observer_Appointment_Date { get; set; }
        public string Observal_Qualification { get; set; }
        public string Observal_Graduation_Institute { get; set; }
        public string Observer_Graduation_Place { get; set; }
        public string Observal_Graduation_Year { get; set; }
        public string Observer_Mobile_No { get; set; }
        public string Observer_Mobile_No_other { get; set; }
        public Nullable<long> Construction_Type { get; set; }
        public Nullable<long> Mosque_Maintenance { get; set; }
        public string Maintenance_Date { get; set; }
        public Nullable<long> Roof_Status { get; set; }
        public Nullable<long> External_Paint_Status { get; set; }
        public Nullable<long> Internal_Paint_Status { get; set; }
        public Nullable<long> Doors_Status { get; set; }
        public Nullable<long> Windows_Status { get; set; }
        public Nullable<long> Cracks_Column { get; set; }
        public Nullable<long> Cracks_Column_Kamar { get; set; }
        public Nullable<long> Cracks_Wall { get; set; }
        public Nullable<long> Cracks_Sotra { get; set; }
        public Nullable<long> Crack_Instructive { get; set; }
        public Nullable<long> Crack_stairs { get; set; }
        public Nullable<long> Crack_extension { get; set; }
        public Nullable<long> Floor_Subsidence { get; set; }
        public Nullable<long> Sidewalk_Subsidence { get; set; }
        public Nullable<long> Courtyard_Subsidence { get; set; }
        public Nullable<long> Water_Leak_Floor { get; set; }
        public Nullable<long> Water_Leak_SideWalk { get; set; }
        public Nullable<long> Water_Leak_Courtyard { get; set; }
        public string Bathrooms_No { get; set; }
        public string Airconditioners_No { get; set; }
        public Nullable<long> Airconditioners_Type { get; set; }
        public Nullable<long> Maintenance_Contract { get; set; }
        public string Maintenance_Contractor { get; set; }
        public Nullable<long> Lighting_Status { get; set; }
        public Nullable<long> Plumbering_Status { get; set; }
        public Nullable<long> Electrical_Wiring_Status { get; set; }
        public Nullable<long> Fans_Status { get; set; }
        public Nullable<long> Airconditioners_Status { get; set; }
        public Nullable<long> Ablution_Places_Status { get; set; }
        public Nullable<long> Ablution_Places_Type { get; set; }
        public string Ablution_Places_No { get; set; }
        public Nullable<long> Health_Articles { get; set; }
        public Nullable<long> Bathrooms_Status { get; set; }
        public Nullable<long> Water_Coolers_Status { get; set; }
        public Nullable<long> Carpets_Status { get; set; }
        public Nullable<long> Microfons_Status { get; set; }
        public string Easting { get; set; }
        public string Northing { get; set; }
        public Nullable<long> Zone_ { get; set; }
        public string Notes { get; set; }
        public string MosqueNationalCode { get; set; }
        public Nullable<long> RegionC { get; set; }
        public Nullable<long> ProvienceC { get; set; }
        public string MosqueID { get; set; }
        //public bool IsDeleted { get; set; }
    }
}
