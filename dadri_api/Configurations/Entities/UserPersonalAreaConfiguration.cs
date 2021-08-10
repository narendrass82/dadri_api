﻿using dadri_api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dadri_api.Configurations.Entities
{
    public class UserPersonalAreaConfiguration : IEntityTypeConfiguration<UserPersonalArea>
    {
        public void Configure(EntityTypeBuilder<UserPersonalArea> builder)
        {
            builder.HasData(
                new UserPersonalArea { PersonalAreaId = 999, PersonalAreaDescription = "Super", PersonalAreaCode = "0", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 1, PersonalAreaDescription = "CC - SCOPE", PersonalAreaCode = "1", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 2, PersonalAreaDescription = "CC - EOC", PersonalAreaCode = "2", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 3, PersonalAreaDescription = "NCG", PersonalAreaCode = "3", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 4, PersonalAreaDescription = "APDP", PersonalAreaCode = "4", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 5, PersonalAreaDescription = "PIE NCR", PersonalAreaCode = "5", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 6, PersonalAreaDescription = "PIE PATNA", PersonalAreaCode = "6", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 100, PersonalAreaDescription = "Consultancy", PersonalAreaCode = "100", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 552, PersonalAreaDescription = "CPG-1", PersonalAreaCode = "552", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 553, PersonalAreaDescription = "CPG-2", PersonalAreaCode = "553", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 612, PersonalAreaDescription = "CPG-3", PersonalAreaCode = "612", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 307, PersonalAreaDescription = "Gidderbaha", PersonalAreaCode = "307", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 308, PersonalAreaDescription = "Kathua", PersonalAreaCode = "308", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 200, PersonalAreaDescription = "NR- HQs", PersonalAreaCode = "200", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 201, PersonalAreaDescription = "NR- TL", PersonalAreaCode = "201", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 202, PersonalAreaDescription = "Singrauli", PersonalAreaCode = "202", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 203, PersonalAreaDescription = "Unchahar", PersonalAreaCode = "203", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 204, PersonalAreaDescription = "Rihand", PersonalAreaCode = "204", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 205, PersonalAreaDescription = "Tanda", PersonalAreaCode = "205", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 206, PersonalAreaDescription = "YNTPP", PersonalAreaCode = "206", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 207, PersonalAreaDescription = "Bilhaur", PersonalAreaCode = "207", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 208, PersonalAreaDescription = "SSC NR-Auraiya", PersonalAreaCode = "208", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 209, PersonalAreaDescription = "SSC NR-Vindhyachal", PersonalAreaCode = "209", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 301, PersonalAreaDescription = "Dadri Thermal", PersonalAreaCode = "301", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 302, PersonalAreaDescription = "Dadri Gas", PersonalAreaCode = "302", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 303, PersonalAreaDescription = "Badarpur", PersonalAreaCode = "303", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 304, PersonalAreaDescription = "Faridabad", PersonalAreaCode = "304", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 306, PersonalAreaDescription = "Auraiya", PersonalAreaCode = "306", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 309, PersonalAreaDescription = "SSC-DBF & Hydro", PersonalAreaCode = "309", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 311, PersonalAreaDescription = "Jetsar Solar Power Project", PersonalAreaCode = "311", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 312, PersonalAreaDescription = "Devikot Solar", PersonalAreaCode = "312", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 313, PersonalAreaDescription = "Shimbhoo Ka Burj Solar", PersonalAreaCode = "313", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 503, PersonalAreaDescription = "Vindhyachal", PersonalAreaCode = "503", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 519, PersonalAreaDescription = "Nokhra Solar PV", PersonalAreaCode = "519", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 520, PersonalAreaDescription = "Fatehgarh Solar Park", PersonalAreaCode = "520", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7510, PersonalAreaDescription = "VSR-HQs", PersonalAreaCode = "7510", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7540, PersonalAreaDescription = "Nokh Solar Plant", PersonalAreaCode = "7540", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 305, PersonalAreaDescription = "Anta", PersonalAreaCode = "305", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 314, PersonalAreaDescription = "Bhuj Solar", PersonalAreaCode = "314", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 500, PersonalAreaDescription = "WR1- HQs", PersonalAreaCode = "500", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 501, PersonalAreaDescription = "WR -TL", PersonalAreaCode = "501", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 504, PersonalAreaDescription = "Kawas", PersonalAreaCode = "504", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 505, PersonalAreaDescription = "Jhanor-Gandhar", PersonalAreaCode = "505", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 507, PersonalAreaDescription = "BALCO", PersonalAreaCode = "507", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 508, PersonalAreaDescription = "Mauda", PersonalAreaCode = "508", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 509, PersonalAreaDescription = "Solapur", PersonalAreaCode = "509", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 514, PersonalAreaDescription = "Dhuvaran", PersonalAreaCode = "514", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 516, PersonalAreaDescription = "Chhabra", PersonalAreaCode = "516", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 517, PersonalAreaDescription = "SSC-WR-1", PersonalAreaCode = "517", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 3001, PersonalAreaDescription = "Bhadla Solar", PersonalAreaCode = "3001", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7520, PersonalAreaDescription = "Rojmal Wind", PersonalAreaCode = "7520", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 400, PersonalAreaDescription = "ER1- HQs", PersonalAreaCode = "400", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 401, PersonalAreaDescription = "ER-TL", PersonalAreaCode = "401", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 402, PersonalAreaDescription = "Farakka", PersonalAreaCode = "402", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 403, PersonalAreaDescription = "Kahalgaon", PersonalAreaCode = "403", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 406, PersonalAreaDescription = "North Karanpura", PersonalAreaCode = "406", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 407, PersonalAreaDescription = "Barh", PersonalAreaCode = "407", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 409, PersonalAreaDescription = "Katwa", PersonalAreaCode = "409", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 413, PersonalAreaDescription = "PC-RGGVY Bhubaneswar", PersonalAreaCode = "413", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 414, PersonalAreaDescription = "Barauni TPS", PersonalAreaCode = "414", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 421, PersonalAreaDescription = "SSC-ER-1", PersonalAreaCode = "421", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7200, PersonalAreaDescription = "KUPS", PersonalAreaCode = "7200", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7220, PersonalAreaDescription = "LBCPL", PersonalAreaCode = "7220", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 518, PersonalAreaDescription = "Ettayapuram Solar", PersonalAreaCode = "518", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 600, PersonalAreaDescription = "SR-HQs", PersonalAreaCode = "600", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 601, PersonalAreaDescription = "SR-TL", PersonalAreaCode = "601", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 602, PersonalAreaDescription = "Ramagundam", PersonalAreaCode = "602", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 603, PersonalAreaDescription = "Simhadri", PersonalAreaCode = "603", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 604, PersonalAreaDescription = "Kayamkulam", PersonalAreaCode = "604", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 605, PersonalAreaDescription = "MNTPP", PersonalAreaCode = "605", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 606, PersonalAreaDescription = "Kudgi", PersonalAreaCode = "606", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 607, PersonalAreaDescription = "REP-Belgaum", PersonalAreaCode = "607", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 608, PersonalAreaDescription = "Pudimadaka", PersonalAreaCode = "608", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 609, PersonalAreaDescription = "Ananthapuram Solar", PersonalAreaCode = "609", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 610, PersonalAreaDescription = "Telangana", PersonalAreaCode = "610", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 611, PersonalAreaDescription = "SSC-SR", PersonalAreaCode = "611", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7530, PersonalAreaDescription = "Andaman Solar", PersonalAreaCode = "7530", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 1000, PersonalAreaDescription = "Hydro-HQs", PersonalAreaCode = "1000", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 1001, PersonalAreaDescription = "Koldam", PersonalAreaCode = "1001", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 1002, PersonalAreaDescription = "Loharinag Pala", PersonalAreaCode = "1002", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 1003, PersonalAreaDescription = "Tapovan Vishnugarh", PersonalAreaCode = "1003", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 1004, PersonalAreaDescription = "Hutong & Kalai", PersonalAreaCode = "1004", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 1005, PersonalAreaDescription = "Khasiabara", PersonalAreaCode = "1005", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 1006, PersonalAreaDescription = "Etalin", PersonalAreaCode = "1006", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 1007, PersonalAreaDescription = "Attunli", PersonalAreaCode = "1007", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 1008, PersonalAreaDescription = "Kolodyne", PersonalAreaCode = "1008", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 1009, PersonalAreaDescription = "Amochu", PersonalAreaCode = "1009", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 5011, PersonalAreaDescription = "Rammam", PersonalAreaCode = "5011", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 5012, PersonalAreaDescription = "Lata Tapovan", PersonalAreaCode = "5012", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 2000, PersonalAreaDescription = "Coal Mining-HQs", PersonalAreaCode = "2000", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 2001, PersonalAreaDescription = "Pakri Barwadih", PersonalAreaCode = "2001", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 2002, PersonalAreaDescription = "Kerandari-A", PersonalAreaCode = "2002", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 2003, PersonalAreaDescription = "Talaipalli", PersonalAreaCode = "2003", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 2004, PersonalAreaDescription = "Chatti Bariatu", PersonalAreaCode = "2004", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 2005, PersonalAreaDescription = "Chhatrasal", PersonalAreaCode = "2005", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 2006, PersonalAreaDescription = "Dulanga", PersonalAreaCode = "2006", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 2008, PersonalAreaDescription = "Mandakini-B", PersonalAreaCode = "2008", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 2009, PersonalAreaDescription = "SSC-Coal Mining", PersonalAreaCode = "2009", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 2010, PersonalAreaDescription = "Badam", PersonalAreaCode = "2010", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7010, PersonalAreaDescription = "NSPCL-HQs", PersonalAreaCode = "7010", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7011, PersonalAreaDescription = "NSPCL-Durgapur", PersonalAreaCode = "7011", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7012, PersonalAreaDescription = "NSPCL-Bhilai", PersonalAreaCode = "7012", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7013, PersonalAreaDescription = "NSPCL-Rourkela", PersonalAreaCode = "7013", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7014, PersonalAreaDescription = "NSPCL-Jagdishpur", PersonalAreaCode = "7014", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7020, PersonalAreaDescription = "NGSL", PersonalAreaCode = "7020", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7030, PersonalAreaDescription = "Ratnagiri-HQs", PersonalAreaCode = "7030", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7031, PersonalAreaDescription = "Ratnagiri", PersonalAreaCode = "7031", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7040, PersonalAreaDescription = "Vallur", PersonalAreaCode = "7040", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7050, PersonalAreaDescription = "Brahmini Coal Mines", PersonalAreaCode = "7050", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7060, PersonalAreaDescription = "UPL", PersonalAreaCode = "7060", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7075, PersonalAreaDescription = "APCPL-HQs", PersonalAreaCode = "7075", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7080, PersonalAreaDescription = "Jhajjar", PersonalAreaCode = "7080", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7090, PersonalAreaDescription = "Meja", PersonalAreaCode = "7090", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7120, PersonalAreaDescription = "NBPPL", PersonalAreaCode = "7120", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7130, PersonalAreaDescription = "TELK", PersonalAreaCode = "7130", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7140, PersonalAreaDescription = "NPEX", PersonalAreaCode = "7140", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7150, PersonalAreaDescription = "BFNSL", PersonalAreaCode = "7150", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7160, PersonalAreaDescription = "EESL", PersonalAreaCode = "7160", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7180, PersonalAreaDescription = "Adra-JV", PersonalAreaCode = "7180", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7190, PersonalAreaDescription = "CIL-NTPC", PersonalAreaCode = "7190", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7210, PersonalAreaDescription = "PARPL", PersonalAreaCode = "7210", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7230, PersonalAreaDescription = "NTPC EDMC Waste Solutions Priv", PersonalAreaCode = "7230", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7300, PersonalAreaDescription = "TPCL", PersonalAreaCode = "7300", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7301, PersonalAreaDescription = "BIFPC", PersonalAreaCode = "7301", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7500, PersonalAreaDescription = "HURL-HQs", PersonalAreaCode = "7500", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 5010, PersonalAreaDescription = "NHL", PersonalAreaCode = "5010", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 5030, PersonalAreaDescription = "NVVN", PersonalAreaCode = "5030", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 5040, PersonalAreaDescription = "NTPC Renewable Energy Limited", PersonalAreaCode = "5040", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 5050, PersonalAreaDescription = "NESCL", PersonalAreaCode = "5050", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 5060, PersonalAreaDescription = "NTPC Foundation", PersonalAreaCode = "5060", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 5070, PersonalAreaDescription = "PPDC", PersonalAreaCode = "5070", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 5080, PersonalAreaDescription = "BRBCL", PersonalAreaCode = "5080", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7070, PersonalAreaDescription = "Kanti", PersonalAreaCode = "7070", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7110, PersonalAreaDescription = "NPGCL", PersonalAreaCode = "7110", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 7170, PersonalAreaDescription = "Patratu", PersonalAreaCode = "7170", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 404, PersonalAreaDescription = "Talcher Kaniha", PersonalAreaCode = "404", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 405, PersonalAreaDescription = "Talcher Thermal", PersonalAreaCode = "405", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 408, PersonalAreaDescription = "Bongaigaon", PersonalAreaCode = "408", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 410, PersonalAreaDescription = "ER2- HQs", PersonalAreaCode = "410", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 411, PersonalAreaDescription = "Darlipalli", PersonalAreaCode = "411", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 412, PersonalAreaDescription = "Gajamara", PersonalAreaCode = "412", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 431, PersonalAreaDescription = "SSC-ER-2", PersonalAreaCode = "431", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 502, PersonalAreaDescription = "Korba", PersonalAreaCode = "502", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 506, PersonalAreaDescription = "Sipat", PersonalAreaCode = "506", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 510, PersonalAreaDescription = "Lara", PersonalAreaCode = "510", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 511, PersonalAreaDescription = "Khargone", PersonalAreaCode = "511", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 512, PersonalAreaDescription = "Gadarwara", PersonalAreaCode = "512", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 513, PersonalAreaDescription = "Barethi", PersonalAreaCode = "513", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 515, PersonalAreaDescription = "Mandsaur Solar", PersonalAreaCode = "515", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 550, PersonalAreaDescription = "WR2- HQs", PersonalAreaCode = "550", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 551, PersonalAreaDescription = "SSC-WR-2", PersonalAreaCode = "551", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 3002, PersonalAreaDescription = "Rajgarh Solar", PersonalAreaCode = "3002", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 3000, PersonalAreaDescription = "RE & N- HQs", PersonalAreaCode = "3000", TypeId = 1 },
                new UserPersonalArea { PersonalAreaId = 310, PersonalAreaDescription = "DBF- HQs", PersonalAreaCode = "310", TypeId = 1 }
            );
        }
    }
}