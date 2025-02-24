namespace Nhl.Api.Common.Helpers;

/// <summary>
/// A helper class for converting ISO standard country codes to the full country name
/// </summary>
public static class CountryCodeHelper
{
    /// <summary>
    /// Converts the ISO 3166 country code to the full country name <br/>
    /// Example: CAN - Canada
    /// </summary>
    public static string ConvertThreeDigitCountryCodeToFullCountryName(string countryCode)
    {

        if (countryCode == "AFG")
        {
            return "Afghanistan";
        }

        if (countryCode == "ALA")
        {
            return "Aland Islands";
        }

        if (countryCode == "ALB")
        {
            return "Albania";
        }

        if (countryCode == "DZA")
        {
            return "Algeria";
        }

        if (countryCode == "ASM")
        {
            return "American Samoa";
        }

        if (countryCode == "AND")
        {
            return "Andorra";
        }

        if (countryCode == "AGO")
        {
            return "Angola";
        }

        if (countryCode == "AIA")
        {
            return "Anguilla";
        }

        if (countryCode == "ATA")
        {
            return "Antarctica";
        }

        if (countryCode == "ATG")
        {
            return "Antigua and Barbuda";
        }

        if (countryCode == "ARG")
        {
            return "Argentina";
        }

        if (countryCode == "ARM")
        {
            return "Armenia";
        }

        if (countryCode == "ABW")
        {
            return "Aruba";
        }

        if (countryCode == "AUS")
        {
            return "Australia";
        }

        if (countryCode == "AUT")
        {
            return "Austria";
        }

        if (countryCode == "AZE")
        {
            return "Azerbaijan";
        }

        if (countryCode == "BHS")
        {
            return "Bahamas";
        }

        if (countryCode == "BHR")
        {
            return "Bahrain";
        }

        if (countryCode == "BGD")
        {
            return "Bangladesh";
        }

        if (countryCode == "BRB")
        {
            return "Barbados";
        }

        if (countryCode == "BLR")
        {
            return "Belarus";
        }

        if (countryCode == "BEL")
        {
            return "Belgium";
        }

        if (countryCode == "BLZ")
        {
            return "Belize";
        }

        if (countryCode == "BEN")
        {
            return "Benin";
        }

        if (countryCode == "BMU")
        {
            return "Bermuda";
        }

        if (countryCode == "BTN")
        {
            return "Bhutan";
        }

        if (countryCode == "BOL")
        {
            return "Bolivia";
        }

        if (countryCode == "BIH")
        {
            return "Bosnia and Herzegovina";
        }

        if (countryCode == "BWA")
        {
            return "Botswana";
        }

        if (countryCode == "BVT")
        {
            return "Bouvet Island";
        }

        if (countryCode == "BRA")
        {
            return "Brazil";
        }

        if (countryCode == "VGB")
        {
            return "British Virgin Islands";
        }

        if (countryCode == "IOT")
        {
            return "British Indian Ocean Territory";
        }

        if (countryCode == "BRN")
        {
            return "Brunei Darussalam";
        }

        if (countryCode == "BGR")
        {
            return "Bulgaria";
        }

        if (countryCode == "BFA")
        {
            return "Burkina Faso";
        }

        if (countryCode == "BDI")
        {
            return "Burundi";
        }

        if (countryCode == "KHM")
        {
            return "Cambodia";
        }

        if (countryCode == "CMR")
        {
            return "Cameroon";
        }

        if (countryCode == "CAN")
        {
            return "Canada";
        }

        if (countryCode == "CPV")
        {
            return "Cape Verde";
        }

        if (countryCode == "CYM")
        {
            return "Cayman Islands";
        }

        if (countryCode == "CAF")
        {
            return "Central African Republic";
        }

        if (countryCode == "TCD")
        {
            return "Chad";
        }

        if (countryCode == "CHL")
        {
            return "Chile";
        }

        if (countryCode == "CHN")
        {
            return "China";
        }

        if (countryCode == "HKG")
        {
            return "Hong Kong, SAR China";
        }

        if (countryCode == "MAC")
        {
            return "Macao, SAR China";
        }

        if (countryCode == "CXR")
        {
            return "Christmas Island";
        }

        if (countryCode == "CCK")
        {
            return "Cocos (Keeling) Islands";
        }

        if (countryCode == "COL")
        {
            return "Colombia";
        }

        if (countryCode == "COM")
        {
            return "Comoros";
        }

        if (countryCode == "COG")
        {
            return "Congo (Brazzaville)";
        }

        if (countryCode == "COD")
        {
            return "Congo, (Kinshasa)";
        }

        if (countryCode == "COK")
        {
            return "Cook Islands";
        }

        if (countryCode == "CRI")
        {
            return "Costa Rica";
        }

        if (countryCode == "CIV")
        {
            return "Côte d'Ivoire";
        }

        if (countryCode == "HRV")
        {
            return "Croatia";
        }

        if (countryCode == "CUB")
        {
            return "Cuba";
        }

        if (countryCode == "CYP")
        {
            return "Cyprus";
        }

        if (countryCode == "CZE")
        {
            return "Czech Republic";
        }

        if (countryCode == "DNK")
        {
            return "Denmark";
        }

        if (countryCode == "DJI")
        {
            return "Djibouti";
        }

        if (countryCode == "DMA")
        {
            return "Dominica";
        }

        if (countryCode == "DOM")
        {
            return "Dominican Republic";
        }

        if (countryCode == "ECU")
        {
            return "Ecuador";
        }

        if (countryCode == "EGY")
        {
            return "Egypt";
        }

        if (countryCode == "SLV")
        {
            return "El Salvador";
        }

        if (countryCode == "GNQ")
        {
            return "Equatorial Guinea";
        }

        if (countryCode == "ERI")
        {
            return "Eritrea";
        }

        if (countryCode == "EST")
        {
            return "Estonia";
        }

        if (countryCode == "ETH")
        {
            return "Ethiopia";
        }

        if (countryCode == "FLK")
        {
            return "Falkland Islands (Malvinas)";
        }

        if (countryCode == "FRO")
        {
            return "Faroe Islands";
        }

        if (countryCode == "FJI")
        {
            return "Fiji";
        }

        if (countryCode == "FIN")
        {
            return "Finland";
        }

        if (countryCode == "FRA")
        {
            return "France";
        }

        if (countryCode == "GUF")
        {
            return "French Guiana";
        }

        if (countryCode == "PYF")
        {
            return "French Polynesia";
        }

        if (countryCode == "ATF")
        {
            return "French Southern Territories";
        }

        if (countryCode == "GAB")
        {
            return "Gabon";
        }

        if (countryCode == "GMB")
        {
            return "Gambia";
        }

        if (countryCode == "GEO")
        {
            return "Georgia";
        }

        if (countryCode == "DEU")
        {
            return "Germany";
        }

        if (countryCode == "GHA")
        {
            return "Ghana";
        }

        if (countryCode == "GIB")
        {
            return "Gibraltar";
        }

        if (countryCode == "GRC")
        {
            return "Greece";
        }

        if (countryCode == "GRL")
        {
            return "Greenland";
        }

        if (countryCode == "GRD")
        {
            return "Grenada";
        }

        if (countryCode == "GLP")
        {
            return "Guadeloupe";
        }

        if (countryCode == "GUM")
        {
            return "Guam";
        }

        if (countryCode == "GTM")
        {
            return "Guatemala";
        }

        if (countryCode == "GGY")
        {
            return "Guernsey";
        }

        if (countryCode == "GIN")
        {
            return "Guinea";
        }

        if (countryCode == "GNB")
        {
            return "Guinea-Bissau";
        }

        if (countryCode == "GUY")
        {
            return "Guyana";
        }

        if (countryCode == "HTI")
        {
            return "Haiti";
        }

        if (countryCode == "HMD")
        {
            return "Heard and Mcdonald Islands";
        }

        if (countryCode == "VAT")
        {
            return "Holy See (Vatican City State)";
        }

        if (countryCode == "HND")
        {
            return "Honduras";
        }

        if (countryCode == "HUN")
        {
            return "Hungary";
        }

        if (countryCode == "ISL")
        {
            return "Iceland";
        }

        if (countryCode == "IND")
        {
            return "India";
        }

        if (countryCode == "IDN")
        {
            return "Indonesia";
        }

        if (countryCode == "IRN")
        {
            return "Iran, Islamic Republic of";
        }

        if (countryCode == "IRQ")
        {
            return "Iraq";
        }

        if (countryCode == "IRL")
        {
            return "Ireland";
        }

        if (countryCode == "IMN")
        {
            return "Isle of Man";
        }

        if (countryCode == "ISR")
        {
            return "Israel";
        }

        if (countryCode == "ITA")
        {
            return "Italy";
        }

        if (countryCode == "JAM")
        {
            return "Jamaica";
        }

        if (countryCode == "JPN")
        {
            return "Japan";
        }

        if (countryCode == "JEY")
        {
            return "Jersey";
        }

        if (countryCode == "JOR")
        {
            return "Jordan";
        }

        if (countryCode == "KAZ")
        {
            return "Kazakhstan";
        }

        if (countryCode == "KEN")
        {
            return "Kenya";
        }

        if (countryCode == "KIR")
        {
            return "Kiribati";
        }

        if (countryCode == "PRK")
        {
            return "Korea (North)";
        }

        if (countryCode == "KOR")
        {
            return "Korea (South)";
        }

        if (countryCode == "KWT")
        {
            return "Kuwait";
        }

        if (countryCode == "KGZ")
        {
            return "Kyrgyzstan";
        }

        if (countryCode == "LAO")
        {
            return "Lao PDR";
        }

        if (countryCode == "LVA")
        {
            return "Latvia";
        }

        if (countryCode == "LBN")
        {
            return "Lebanon";
        }

        if (countryCode == "LSO")
        {
            return "Lesotho";
        }

        if (countryCode == "LBR")
        {
            return "Liberia";
        }

        if (countryCode == "LBY")
        {
            return "Libya";
        }

        if (countryCode == "LIE")
        {
            return "Liechtenstein";
        }

        if (countryCode == "LTU")
        {
            return "Lithuania";
        }

        if (countryCode == "LUX")
        {
            return "Luxembourg";
        }

        if (countryCode == "MKD")
        {
            return "Macedonia, Republic of";
        }

        if (countryCode == "MDG")
        {
            return "Madagascar";
        }

        if (countryCode == "MWI")
        {
            return "Malawi";
        }

        if (countryCode == "MYS")
        {
            return "Malaysia";
        }

        if (countryCode == "MDV")
        {
            return "Maldives";
        }

        if (countryCode == "MLI")
        {
            return "Mali";
        }

        if (countryCode == "MLT")
        {
            return "Malta";
        }

        if (countryCode == "MHL")
        {
            return "Marshall Islands";
        }

        if (countryCode == "MTQ")
        {
            return "Martinique";
        }

        if (countryCode == "MRT")
        {
            return "Mauritania";
        }

        if (countryCode == "MUS")
        {
            return "Mauritius";
        }

        if (countryCode == "MYT")
        {
            return "Mayotte";
        }

        if (countryCode == "MEX")
        {
            return "Mexico";
        }

        if (countryCode == "FSM")
        {
            return "Micronesia";
        }

        if (countryCode == "MDA")
        {
            return "Moldova";
        }

        if (countryCode == "MCO")
        {
            return "Monaco";
        }

        if (countryCode == "MNG")
        {
            return "Mongolia";
        }

        if (countryCode == "MNE")
        {
            return "Montenegro";
        }

        if (countryCode == "MSR")
        {
            return "Montserrat";
        }

        if (countryCode == "MAR")
        {
            return "Morocco";
        }

        if (countryCode == "MOZ")
        {
            return "Mozambique";
        }

        if (countryCode == "MMR")
        {
            return "Myanmar";
        }

        if (countryCode == "NAM")
        {
            return "Namibia";
        }

        if (countryCode == "NRU")
        {
            return "Nauru";
        }

        if (countryCode == "NPL")
        {
            return "Nepal";
        }

        if (countryCode == "NLD")
        {
            return "Netherlands";
        }

        if (countryCode == "ANT")
        {
            return "Netherlands Antilles";
        }

        if (countryCode == "NCL")
        {
            return "New Caledonia";
        }

        if (countryCode == "NZL")
        {
            return "New Zealand";
        }

        if (countryCode == "NIC")
        {
            return "Nicaragua";
        }

        if (countryCode == "NER")
        {
            return "Niger";
        }

        if (countryCode == "NGA")
        {
            return "Nigeria";
        }

        if (countryCode == "NIU")
        {
            return "Niue";
        }

        if (countryCode == "NFK")
        {
            return "Norfolk Island";
        }

        if (countryCode == "MNP")
        {
            return "Northern Mariana Islands";
        }

        if (countryCode == "NOR")
        {
            return "Norway";
        }

        if (countryCode == "OMN")
        {
            return "Oman";
        }

        if (countryCode == "PAK")
        {
            return "Pakistan";
        }

        if (countryCode == "PLW")
        {
            return "Palau";
        }

        if (countryCode == "PSE")
        {
            return "Palestinian Territory";
        }

        if (countryCode == "PAN")
        {
            return "Panama";
        }

        if (countryCode == "PNG")
        {
            return "Papua New Guinea";
        }

        if (countryCode == "PRY")
        {
            return "Paraguay";
        }

        if (countryCode == "PER")
        {
            return "Peru";
        }

        if (countryCode == "PHL")
        {
            return "Philippines";
        }

        if (countryCode == "PCN")
        {
            return "Pitcairn";
        }

        if (countryCode == "POL")
        {
            return "Poland";
        }

        if (countryCode == "PRT")
        {
            return "Portugal";
        }

        if (countryCode == "PRI")
        {
            return "Puerto Rico";
        }

        if (countryCode == "QAT")
        {
            return "Qatar";
        }

        if (countryCode == "REU")
        {
            return "Réunion";
        }

        if (countryCode == "ROU")
        {
            return "Romania";
        }

        if (countryCode == "RUS")
        {
            return "Russian Federation";
        }

        if (countryCode == "RWA")
        {
            return "Rwanda";
        }

        if (countryCode == "BLM")
        {
            return "Saint-Barthélemy";
        }

        if (countryCode == "SHN")
        {
            return "Saint Helena";
        }

        if (countryCode == "KNA")
        {
            return "Saint Kitts and Nevis";
        }

        if (countryCode == "LCA")
        {
            return "Saint Lucia";
        }

        if (countryCode == "MAF")
        {
            return "Saint-Martin (French part)";
        }

        if (countryCode == "SPM")
        {
            return "Saint Pierre and Miquelon";
        }

        if (countryCode == "VCT")
        {
            return "Saint Vincent and Grenadines";
        }

        if (countryCode == "WSM")
        {
            return "Samoa";
        }

        if (countryCode == "SMR")
        {
            return "San Marino";
        }

        if (countryCode == "STP")
        {
            return "Sao Tome and Principe";
        }

        if (countryCode == "SAU")
        {
            return "Saudi Arabia";
        }

        if (countryCode == "SEN")
        {
            return "Senegal";
        }

        if (countryCode == "SRB")
        {
            return "Serbia";
        }

        if (countryCode == "SYC")
        {
            return "Seychelles";
        }

        if (countryCode == "SLE")
        {
            return "Sierra Leone";
        }

        if (countryCode == "SGP")
        {
            return "Singapore";
        }

        if (countryCode == "SVK")
        {
            return "Slovakia";
        }

        if (countryCode == "SVN")
        {
            return "Slovenia";
        }

        if (countryCode == "SLB")
        {
            return "Solomon Islands";
        }

        if (countryCode == "SOM")
        {
            return "Somalia";
        }

        if (countryCode == "ZAF")
        {
            return "South Africa";
        }

        if (countryCode == "SGS")
        {
            return "South Georgia and the South Sandwich Islands";
        }

        if (countryCode == "SSD")
        {
            return "South Sudan";
        }

        if (countryCode == "ESP")
        {
            return "Spain";
        }

        if (countryCode == "LKA")
        {
            return "Sri Lanka";
        }

        if (countryCode == "SDN")
        {
            return "Sudan";
        }

        if (countryCode == "SUR")
        {
            return "Suriname";
        }

        if (countryCode == "SJM")
        {
            return "Svalbard and Jan Mayen Islands";
        }

        if (countryCode == "SWZ")
        {
            return "Swaziland";
        }

        if (countryCode == "SWE")
        {
            return "Sweden";
        }

        if (countryCode == "CHE")
        {
            return "Switzerland";
        }

        if (countryCode == "SYR")
        {
            return "Syrian Arab Republic (Syria)";
        }

        if (countryCode == "TWN")
        {
            return "Taiwan, Republic of China";
        }

        if (countryCode == "TJK")
        {
            return "Tajikistan";
        }

        if (countryCode == "TZA")
        {
            return "Tanzania, United Republic of";
        }

        if (countryCode == "THA")
        {
            return "Thailand";
        }

        if (countryCode == "TLS")
        {
            return "Timor-Leste";
        }

        if (countryCode == "TGO")
        {
            return "Togo";
        }

        if (countryCode == "TKL")
        {
            return "Tokelau";
        }

        if (countryCode == "TON")
        {
            return "Tonga";
        }

        if (countryCode == "TTO")
        {
            return "Trinidad and Tobago";
        }

        if (countryCode == "TUN")
        {
            return "Tunisia";
        }

        if (countryCode == "TUR")
        {
            return "Turkey";
        }

        if (countryCode == "TKM")
        {
            return "Turkmenistan";
        }

        if (countryCode == "TCA")
        {
            return "Turks and Caicos Islands";
        }

        if (countryCode == "TUV")
        {
            return "Tuvalu";
        }

        if (countryCode == "UGA")
        {
            return "Uganda";
        }

        if (countryCode == "UKR")
        {
            return "Ukraine";
        }

        if (countryCode == "ARE")
        {
            return "United Arab Emirates";
        }

        if (countryCode == "GBR")
        {
            return "United Kingdom";
        }

        if (countryCode == "USA")
        {
            return "United States of America";
        }

        if (countryCode == "UMI")
        {
            return "US Minor Outlying Islands";
        }

        if (countryCode == "URY")
        {
            return "Uruguay";
        }

        if (countryCode == "UZB")
        {
            return "Uzbekistan";
        }

        if (countryCode == "VUT")
        {
            return "Vanuatu";
        }

        if (countryCode == "VEN")
        {
            return "Venezuela (Bolivarian Republic)";
        }

        if (countryCode == "VNM")
        {
            return "Viet Nam";
        }

        if (countryCode == "VIR")
        {
            return "Virgin Islands, US";
        }

        if (countryCode == "WLF")
        {
            return "Wallis and Futuna Islands";
        }

        if (countryCode == "ESH")
        {
            return "Western Sahara";
        }

        if (countryCode == "YEM")
        {
            return "Yemen";
        }

        if (countryCode == "ZMB")
        {
            return "Zambia";
        }

        if (countryCode == "ZWE")
        {
            return "Zimbabwe";
        }

        return string.Empty;
    }
}
