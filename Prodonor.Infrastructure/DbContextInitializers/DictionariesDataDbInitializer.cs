using System;

namespace Prodonor.Infrastructure.DbContextInitializers
{
    /// <summary>
    /// Contains logic for feeding initial data to dictionaries 
    /// </summary>
    public class DictionariesDataDbInitializer : IDictionariesDataDbInitializer
    {
        private readonly ProdonorDbContext _dbContext;

        public DictionariesDataDbInitializer(ProdonorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            try
            {
//                CreateStates();
//                CreateCountries();
//                CreateAreaOfInterests();
//                CreateEducationLevels();
//                CreateMilitaries();
//                CreateAgents();
//                _dbContext.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

//        private void CreateMilitaries()
//        {
//            if (!_dbContext.Militaries.Any())
//            {
//                _dbContext.Militaries.AddRange(new MilitaryDao {Id = 1, Name = "None"}, 
//                    new MilitaryDao {Id = 2, Name = "Active Duty"}, 
//                    new MilitaryDao {Id = 3, Name = "Veteran"}, 
//                    new MilitaryDao {Id = 4, Name = "Guard"}, 
//                    new MilitaryDao {Id = 5, Name = "Reserve"}, 
//                    new MilitaryDao {Id = 6, Name = "Spouse"}, 
//                    new MilitaryDao {Id = 7, Name = "Dependent"});
//            }
//        }
//
//        private void CreateAgents()
//        {
//            if (!_dbContext.Agents.Any())
//            {
//                _dbContext.Agents.AddRange(
//                    new AgentDao() { Name = "Alexa Canell", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "alexacanell", Password = "acanel123" } } },
//                    new AgentDao() { Name = "Ashley Waller", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "awaller", Password = "awaller123" } } },
//                    new AgentDao() { Name = "Belinda F Celayir", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "belindafcelayir", Password = "bcelayir123" } } },
//                    new AgentDao() { Name = "Cassandra Brown", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "cbrown", Password = "cbrown123" } } },
//                    new AgentDao() { Name = "Charles Poole", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "charlespoole", Password = "cpoole123" } } },
//                    new AgentDao() { Name = "Courtney Galvan", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "courtneygalvan", Password = "cgalvan123" } } },
//                    new AgentDao() { Name = "David E Toton", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "davidtoton", Password = "dtoton123" } } },
//                    new AgentDao() { Name = "David E Wiseman", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "davidwiseman", Password = "dwiseman123" } } },
//                    new AgentDao() { Name = "David M Johnson", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "davidmjohnson", Password = "dmjohnson123" } } },
//                    new AgentDao() { Name = "Denise Rice", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "deniserice", Password = "drice123" } } },
//                    new AgentDao() { Name = "Desiree Davie", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "desireedavie", Password = "ddavie123" } } },
//                    new AgentDao() { Name = "Diane Lopez", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "dlopez", Password = "dlopez123" } } },
//                    new AgentDao() { Name = "Dinwall A Brown", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "dinwalabrown", Password = "dbrown123" } } },
//                    new AgentDao() { Name = "Fernando G Crissien", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "fernandogcrissien", Password = "fgcrissien123" } } },
//                    new AgentDao() { Name = "Jamie August", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "jamieaugust", Password = "jaugust123" } } },
//                    new AgentDao() { Name = "Jennifer L Miller", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "jenniferlmiller", Password = "jlmiller123" } } },
//                    new AgentDao() { Name = "Jenny R Charleston", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "jennyrcharleston", Password = "jrcharleston123" } } },
//                    new AgentDao() { Name = "Jerica Jackson", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "jericajackson", Password = "jjackson123" } } },
//                    new AgentDao() { Name = "Johnny H Pierre", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "johnnypierre", Password = "jpierre123" } } },
//                    new AgentDao() { Name = "Jovae A Morris", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "jovaeamorris", Password = "jamorris123" } } },
//                    new AgentDao() { Name = "Milton Smith", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "miltonsmith", Password = "msmith123" } } },
//                    new AgentDao() { Name = "Sheryl L Payseno Holtsclaw", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "sheryllpaysenoholtsclaw", Password = "spaysenoholtsclaw123" } } },
//                    new AgentDao() { Name = "Stephen Campbell", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "scampbell", Password = "scampbell123" } } },
//                    new AgentDao() { Name = "Whitney K Smith", Credentials = new List<CredentialDao> { new CredentialDao() { ExternalSystemId = ExternalSystemEnum.KeyPath, Login = "whitneyksmith", Password = "wksmith123" } } }
//
//                );
//            }
//        }
//
//        private void CreateCountries()
//        {
//            if (!_dbContext.Countries.Any())
//            {
//                _dbContext.Countries.AddRange(
//                    new CountryDao() {Id = 1, Shortname = "AF", Name = "Afghanistan"},
//                    new CountryDao() {Id = 2, Shortname = "AL", Name = "Albania"},
//                    new CountryDao() {Id = 3, Shortname = "DZ", Name = "Algeria"},
//                    new CountryDao() {Id = 4, Shortname = "AS", Name = "American Samoa"},
//                    new CountryDao() {Id = 5, Shortname = "AD", Name = "Andorra"},
//                    new CountryDao() {Id = 6, Shortname = "AO", Name = "Angola"},
//                    new CountryDao() {Id = 7, Shortname = "AI", Name = "Anguilla"},
//                    new CountryDao() {Id = 8, Shortname = "AQ", Name = "Antarctica"},
//                    new CountryDao() {Id = 9, Shortname = "AG", Name = "Antigua And Barbuda"},
//                    new CountryDao() {Id = 10, Shortname = "AR", Name = "Argentina"},
//                    new CountryDao() {Id = 11, Shortname = "AM", Name = "Armenia"},
//                    new CountryDao() {Id = 12, Shortname = "AW", Name = "Aruba"},
//                    new CountryDao() {Id = 13, Shortname = "AU", Name = "Australia"},
//                    new CountryDao() {Id = 14, Shortname = "AT", Name = "Austria"},
//                    new CountryDao() {Id = 15, Shortname = "AZ", Name = "Azerbaijan"},
//                    new CountryDao() {Id = 16, Shortname = "BS", Name = "Bahamas The"},
//                    new CountryDao() {Id = 17, Shortname = "BH", Name = "Bahrain"},
//                    new CountryDao() {Id = 18, Shortname = "BD", Name = "Bangladesh"},
//                    new CountryDao() {Id = 19, Shortname = "BB", Name = "Barbados"},
//                    new CountryDao() {Id = 20, Shortname = "BY", Name = "Belarus"},
//                    new CountryDao() {Id = 21, Shortname = "BE", Name = "Belgium"},
//                    new CountryDao() {Id = 22, Shortname = "BZ", Name = "Belize"},
//                    new CountryDao() {Id = 23, Shortname = "BJ", Name = "Benin"},
//                    new CountryDao() {Id = 24, Shortname = "BM", Name = "Bermuda"},
//                    new CountryDao() {Id = 25, Shortname = "BT", Name = "Bhutan"},
//                    new CountryDao() {Id = 26, Shortname = "BO", Name = "Bolivia"},
//                    new CountryDao() {Id = 27, Shortname = "BA", Name = "Bosnia and Herzegovina"},
//                    new CountryDao() {Id = 28, Shortname = "BW", Name = "Botswana"},
//                    new CountryDao() {Id = 29, Shortname = "BV", Name = "Bouvet Island"},
//                    new CountryDao() {Id = 30, Shortname = "BR", Name = "Brazil"},
//                    new CountryDao() {Id = 31, Shortname = "IO", Name = "British Indian Ocean Territory"},
//                    new CountryDao() {Id = 32, Shortname = "BN", Name = "Brunei"},
//                    new CountryDao() {Id = 33, Shortname = "BG", Name = "Bulgaria"},
//                    new CountryDao() {Id = 34, Shortname = "BF", Name = "Burkina Faso"},
//                    new CountryDao() {Id = 35, Shortname = "BI", Name = "Burundi"},
//                    new CountryDao() {Id = 36, Shortname = "KH", Name = "Cambodia"},
//                    new CountryDao() {Id = 37, Shortname = "CM", Name = "Cameroon"},
//                    new CountryDao() {Id = 38, Shortname = "CA", Name = "Canada"},
//                    new CountryDao() {Id = 39, Shortname = "CV", Name = "Cape Verde"},
//                    new CountryDao() {Id = 40, Shortname = "KY", Name = "Cayman Islands"},
//                    new CountryDao() {Id = 41, Shortname = "CF", Name = "Central African Republic"},
//                    new CountryDao() {Id = 42, Shortname = "TD", Name = "Chad"},
//                    new CountryDao() {Id = 43, Shortname = "CL", Name = "Chile"},
//                    new CountryDao() {Id = 44, Shortname = "CN", Name = "China"},
//                    new CountryDao() {Id = 45, Shortname = "CX", Name = "Christmas Island"},
//                    new CountryDao() {Id = 46, Shortname = "CC", Name = "Cocos (Keeling) Islands"},
//                    new CountryDao() {Id = 47, Shortname = "CO", Name = "Colombia"},
//                    new CountryDao() {Id = 48, Shortname = "KM", Name = "Comoros"},
//                    new CountryDao() {Id = 49, Shortname = "CG", Name = "Republic Of The Congo"},
//                    new CountryDao() {Id = 50, Shortname = "CD", Name = "Democratic Republic Of The Congo"},
//                    new CountryDao() {Id = 51, Shortname = "CK", Name = "Cook Islands"},
//                    new CountryDao() {Id = 52, Shortname = "CR", Name = "Costa Rica"},
//                    new CountryDao() {Id = 53, Shortname = "CI", Name = "Cote D'Ivoire (Ivory Coast)"},
//                    new CountryDao() {Id = 54, Shortname = "HR", Name = "Croatia (Hrvatska)"},
//                    new CountryDao() {Id = 55, Shortname = "CU", Name = "Cuba"},
//                    new CountryDao() {Id = 56, Shortname = "CY", Name = "Cyprus"},
//                    new CountryDao() {Id = 57, Shortname = "CZ", Name = "Czech Republic"},
//                    new CountryDao() {Id = 58, Shortname = "DK", Name = "Denmark"},
//                    new CountryDao() {Id = 59, Shortname = "DJ", Name = "Djibouti"},
//                    new CountryDao() {Id = 60, Shortname = "DM", Name = "Dominica"},
//                    new CountryDao() {Id = 61, Shortname = "DO", Name = "Dominican Republic"},
//                    new CountryDao() {Id = 62, Shortname = "TP", Name = "East Timor"},
//                    new CountryDao() {Id = 63, Shortname = "EC", Name = "Ecuador"},
//                    new CountryDao() {Id = 64, Shortname = "EG", Name = "Egypt"},
//                    new CountryDao() {Id = 65, Shortname = "SV", Name = "El Salvador"},
//                    new CountryDao() {Id = 66, Shortname = "GQ", Name = "Equatorial Guinea"},
//                    new CountryDao() {Id = 67, Shortname = "ER", Name = "Eritrea"},
//                    new CountryDao() {Id = 68, Shortname = "EE", Name = "Estonia"},
//                    new CountryDao() {Id = 69, Shortname = "ET", Name = "Ethiopia"},
//                    new CountryDao() {Id = 70, Shortname = "XA", Name = "External Territories of Australia"},
//                    new CountryDao() {Id = 71, Shortname = "FK", Name = "Falkland Islands"},
//                    new CountryDao() {Id = 72, Shortname = "FO", Name = "Faroe Islands"},
//                    new CountryDao() {Id = 73, Shortname = "FJ", Name = "Fiji Islands"},
//                    new CountryDao() {Id = 74, Shortname = "FI", Name = "Finland"},
//                    new CountryDao() {Id = 75, Shortname = "FR", Name = "France"},
//                    new CountryDao() {Id = 76, Shortname = "GF", Name = "French Guiana"},
//                    new CountryDao() {Id = 77, Shortname = "PF", Name = "French Polynesia"},
//                    new CountryDao() {Id = 78, Shortname = "TF", Name = "French Southern Territories"},
//                    new CountryDao() {Id = 79, Shortname = "GA", Name = "Gabon"},
//                    new CountryDao() {Id = 80, Shortname = "GM", Name = "Gambia The"},
//                    new CountryDao() {Id = 81, Shortname = "GE", Name = "Georgia"},
//                    new CountryDao() {Id = 82, Shortname = "DE", Name = "Germany"},
//                    new CountryDao() {Id = 83, Shortname = "GH", Name = "Ghana"},
//                    new CountryDao() {Id = 84, Shortname = "GI", Name = "Gibraltar"},
//                    new CountryDao() {Id = 85, Shortname = "GR", Name = "Greece"},
//                    new CountryDao() {Id = 86, Shortname = "GL", Name = "Greenland"},
//                    new CountryDao() {Id = 87, Shortname = "GD", Name = "Grenada"},
//                    new CountryDao() {Id = 88, Shortname = "GP", Name = "Guadeloupe"},
//                    new CountryDao() {Id = 89, Shortname = "GU", Name = "Guam"},
//                    new CountryDao() {Id = 90, Shortname = "GT", Name = "Guatemala"},
//                    new CountryDao() {Id = 91, Shortname = "XU", Name = "Guernsey and Alderney"},
//                    new CountryDao() {Id = 92, Shortname = "GN", Name = "Guinea"},
//                    new CountryDao() {Id = 93, Shortname = "GW", Name = "Guinea-Bissau"},
//                    new CountryDao() {Id = 94, Shortname = "GY", Name = "Guyana"},
//                    new CountryDao() {Id = 95, Shortname = "HT", Name = "Haiti"},
//                    new CountryDao() {Id = 96, Shortname = "HM", Name = "Heard and McDonald Islands"},
//                    new CountryDao() {Id = 97, Shortname = "HN", Name = "Honduras"},
//                    new CountryDao() {Id = 98, Shortname = "HK", Name = "Hong Kong S.A.R."},
//                    new CountryDao() {Id = 99, Shortname = "HU", Name = "Hungary"},
//                    new CountryDao() {Id = 100, Shortname = "IS", Name = "Iceland"},
//                    new CountryDao() {Id = 101, Shortname = "IN", Name = "India"},
//                    new CountryDao() {Id = 102, Shortname = "ID", Name = "Indonesia"},
//                    new CountryDao() {Id = 103, Shortname = "IR", Name = "Iran"},
//                    new CountryDao() {Id = 104, Shortname = "IQ", Name = "Iraq"},
//                    new CountryDao() {Id = 105, Shortname = "IE", Name = "Ireland"},
//                    new CountryDao() {Id = 106, Shortname = "IL", Name = "Israel"},
//                    new CountryDao() {Id = 107, Shortname = "IT", Name = "Italy"},
//                    new CountryDao() {Id = 108, Shortname = "JM", Name = "Jamaica"},
//                    new CountryDao() {Id = 109, Shortname = "JP", Name = "Japan"},
//                    new CountryDao() {Id = 110, Shortname = "XJ", Name = "Jersey"},
//                    new CountryDao() {Id = 111, Shortname = "JO", Name = "Jordan"},
//                    new CountryDao() {Id = 112, Shortname = "KZ", Name = "Kazakhstan"},
//                    new CountryDao() {Id = 113, Shortname = "KE", Name = "Kenya"},
//                    new CountryDao() {Id = 114, Shortname = "KI", Name = "Kiribati"},
//                    new CountryDao() {Id = 115, Shortname = "KP", Name = "Korea North"},
//                    new CountryDao() {Id = 116, Shortname = "KR", Name = "Korea South"},
//                    new CountryDao() {Id = 117, Shortname = "KW", Name = "Kuwait"},
//                    new CountryDao() {Id = 118, Shortname = "KG", Name = "Kyrgyzstan"},
//                    new CountryDao() {Id = 119, Shortname = "LA", Name = "Laos"},
//                    new CountryDao() {Id = 120, Shortname = "LV", Name = "Latvia"},
//                    new CountryDao() {Id = 121, Shortname = "LB", Name = "Lebanon"},
//                    new CountryDao() {Id = 122, Shortname = "LS", Name = "Lesotho"},
//                    new CountryDao() {Id = 123, Shortname = "LR", Name = "Liberia"},
//                    new CountryDao() {Id = 124, Shortname = "LY", Name = "Libya"},
//                    new CountryDao() {Id = 125, Shortname = "LI", Name = "Liechtenstein"},
//                    new CountryDao() {Id = 126, Shortname = "LT", Name = "Lithuania"},
//                    new CountryDao() {Id = 127, Shortname = "LU", Name = "Luxembourg"},
//                    new CountryDao() {Id = 128, Shortname = "MO", Name = "Macau S.A.R."},
//                    new CountryDao() {Id = 129, Shortname = "MK", Name = "Macedonia"},
//                    new CountryDao() {Id = 130, Shortname = "MG", Name = "Madagascar"},
//                    new CountryDao() {Id = 131, Shortname = "MW", Name = "Malawi"},
//                    new CountryDao() {Id = 132, Shortname = "MY", Name = "Malaysia"},
//                    new CountryDao() {Id = 133, Shortname = "MV", Name = "Maldives"},
//                    new CountryDao() {Id = 134, Shortname = "ML", Name = "Mali"},
//                    new CountryDao() {Id = 135, Shortname = "MT", Name = "Malta"},
//                    new CountryDao() {Id = 136, Shortname = "XM", Name = "Man (Isle of)"},
//                    new CountryDao() {Id = 137, Shortname = "MH", Name = "Marshall Islands"},
//                    new CountryDao() {Id = 138, Shortname = "MQ", Name = "Martinique"},
//                    new CountryDao() {Id = 139, Shortname = "MR", Name = "Mauritania"},
//                    new CountryDao() {Id = 140, Shortname = "MU", Name = "Mauritius"},
//                    new CountryDao() {Id = 141, Shortname = "YT", Name = "Mayotte"},
//                    new CountryDao() {Id = 142, Shortname = "MX", Name = "Mexico"},
//                    new CountryDao() {Id = 143, Shortname = "FM", Name = "Micronesia"},
//                    new CountryDao() {Id = 144, Shortname = "MD", Name = "Moldova"},
//                    new CountryDao() {Id = 145, Shortname = "MC", Name = "Monaco"},
//                    new CountryDao() {Id = 146, Shortname = "MN", Name = "Mongolia"},
//                    new CountryDao() {Id = 147, Shortname = "MS", Name = "Montserrat"},
//                    new CountryDao() {Id = 148, Shortname = "MA", Name = "Morocco"},
//                    new CountryDao() {Id = 149, Shortname = "MZ", Name = "Mozambique"},
//                    new CountryDao() {Id = 150, Shortname = "MM", Name = "Myanmar"},
//                    new CountryDao() {Id = 151, Shortname = "NA", Name = "Namibia"},
//                    new CountryDao() {Id = 152, Shortname = "NR", Name = "Nauru"},
//                    new CountryDao() {Id = 153, Shortname = "NP", Name = "Nepal"},
//                    new CountryDao() {Id = 154, Shortname = "AN", Name = "Netherlands Antilles"},
//                    new CountryDao() {Id = 155, Shortname = "NL", Name = "Netherlands The"},
//                    new CountryDao() {Id = 156, Shortname = "NC", Name = "New Caledonia"},
//                    new CountryDao() {Id = 157, Shortname = "NZ", Name = "New Zealand"},
//                    new CountryDao() {Id = 158, Shortname = "NI", Name = "Nicaragua"},
//                    new CountryDao() {Id = 159, Shortname = "NE", Name = "Niger"},
//                    new CountryDao() {Id = 160, Shortname = "NG", Name = "Nigeria"},
//                    new CountryDao() {Id = 161, Shortname = "NU", Name = "Niue"},
//                    new CountryDao() {Id = 162, Shortname = "NF", Name = "Norfolk Island"},
//                    new CountryDao() {Id = 163, Shortname = "MP", Name = "Northern Mariana Islands"},
//                    new CountryDao() {Id = 164, Shortname = "NO", Name = "Norway"},
//                    new CountryDao() {Id = 165, Shortname = "OM", Name = "Oman"},
//                    new CountryDao() {Id = 166, Shortname = "PK", Name = "Pakistan"},
//                    new CountryDao() {Id = 167, Shortname = "PW", Name = "Palau"},
//                    new CountryDao() {Id = 168, Shortname = "PS", Name = "Palestinian Territory Occupied"},
//                    new CountryDao() {Id = 169, Shortname = "PA", Name = "Panama"},
//                    new CountryDao() {Id = 170, Shortname = "PG", Name = "Papua new Guinea"},
//                    new CountryDao() {Id = 171, Shortname = "PY", Name = "Paraguay"},
//                    new CountryDao() {Id = 172, Shortname = "PE", Name = "Peru"},
//                    new CountryDao() {Id = 173, Shortname = "PH", Name = "Philippines"},
//                    new CountryDao() {Id = 174, Shortname = "PN", Name = "Pitcairn Island"},
//                    new CountryDao() {Id = 175, Shortname = "PL", Name = "Poland"},
//                    new CountryDao() {Id = 176, Shortname = "PT", Name = "Portugal"},
//                    new CountryDao() {Id = 177, Shortname = "PR", Name = "Puerto Rico"},
//                    new CountryDao() {Id = 178, Shortname = "QA", Name = "Qatar"},
//                    new CountryDao() {Id = 179, Shortname = "RE", Name = "Reunion"},
//                    new CountryDao() {Id = 180, Shortname = "RO", Name = "Romania"},
//                    new CountryDao() {Id = 181, Shortname = "RU", Name = "Russia"},
//                    new CountryDao() {Id = 182, Shortname = "RW", Name = "Rwanda"},
//                    new CountryDao() {Id = 183, Shortname = "SH", Name = "Saint Helena"},
//                    new CountryDao() {Id = 184, Shortname = "KN", Name = "Saint Kitts And Nevis"},
//                    new CountryDao() {Id = 185, Shortname = "LC", Name = "Saint Lucia"},
//                    new CountryDao() {Id = 186, Shortname = "PM", Name = "Saint Pierre and Miquelon"},
//                    new CountryDao() {Id = 187, Shortname = "VC", Name = "Saint Vincent And The Grenadines"},
//                    new CountryDao() {Id = 188, Shortname = "WS", Name = "Samoa"},
//                    new CountryDao() {Id = 189, Shortname = "SM", Name = "San Marino"},
//                    new CountryDao() {Id = 190, Shortname = "ST", Name = "Sao Tome and Principe"},
//                    new CountryDao() {Id = 191, Shortname = "SA", Name = "Saudi Arabia"},
//                    new CountryDao() {Id = 192, Shortname = "SN", Name = "Senegal"},
//                    new CountryDao() {Id = 193, Shortname = "RS", Name = "Serbia"},
//                    new CountryDao() {Id = 194, Shortname = "SC", Name = "Seychelles"},
//                    new CountryDao() {Id = 195, Shortname = "SL", Name = "Sierra Leone"},
//                    new CountryDao() {Id = 196, Shortname = "SG", Name = "Singapore"},
//                    new CountryDao() {Id = 197, Shortname = "SK", Name = "Slovakia"},
//                    new CountryDao() {Id = 198, Shortname = "SI", Name = "Slovenia"},
//                    new CountryDao() {Id = 199, Shortname = "XG", Name = "Smaller Territories of the UK"},
//                    new CountryDao() {Id = 200, Shortname = "SB", Name = "Solomon Islands"},
//                    new CountryDao() {Id = 201, Shortname = "SO", Name = "Somalia"},
//                    new CountryDao() {Id = 202, Shortname = "ZA", Name = "South Africa"},
//                    new CountryDao() {Id = 203, Shortname = "GS", Name = "South Georgia"},
//                    new CountryDao() {Id = 204, Shortname = "SS", Name = "South Sudan"},
//                    new CountryDao() {Id = 205, Shortname = "ES", Name = "Spain"},
//                    new CountryDao() {Id = 206, Shortname = "LK", Name = "Sri Lanka"},
//                    new CountryDao() {Id = 207, Shortname = "SD", Name = "Sudan"},
//                    new CountryDao() {Id = 208, Shortname = "SR", Name = "Suriname"},
//                    new CountryDao() {Id = 209, Shortname = "SJ", Name = "Svalbard And Jan Mayen Islands"},
//                    new CountryDao() {Id = 210, Shortname = "SZ", Name = "Swaziland"},
//                    new CountryDao() {Id = 211, Shortname = "SE", Name = "Sweden"},
//                    new CountryDao() {Id = 212, Shortname = "CH", Name = "Switzerland"},
//                    new CountryDao() {Id = 213, Shortname = "SY", Name = "Syria"},
//                    new CountryDao() {Id = 214, Shortname = "TW", Name = "Taiwan"},
//                    new CountryDao() {Id = 215, Shortname = "TJ", Name = "Tajikistan"},
//                    new CountryDao() {Id = 216, Shortname = "TZ", Name = "Tanzania"},
//                    new CountryDao() {Id = 217, Shortname = "TH", Name = "Thailand"},
//                    new CountryDao() {Id = 218, Shortname = "TG", Name = "Togo"},
//                    new CountryDao() {Id = 219, Shortname = "TK", Name = "Tokelau"},
//                    new CountryDao() {Id = 220, Shortname = "TO", Name = "Tonga"},
//                    new CountryDao() {Id = 221, Shortname = "TT", Name = "Trinidad And Tobago"},
//                    new CountryDao() {Id = 222, Shortname = "TN", Name = "Tunisia"},
//                    new CountryDao() {Id = 223, Shortname = "TR", Name = "Turkey"},
//                    new CountryDao() {Id = 224, Shortname = "TM", Name = "Turkmenistan"},
//                    new CountryDao() {Id = 225, Shortname = "TC", Name = "Turks And Caicos Islands"},
//                    new CountryDao() {Id = 226, Shortname = "TV", Name = "Tuvalu"},
//                    new CountryDao() {Id = 227, Shortname = "UG", Name = "Uganda"},
//                    new CountryDao() {Id = 228, Shortname = "UA", Name = "Ukraine"},
//                    new CountryDao() {Id = 229, Shortname = "AE", Name = "United Arab Emirates"},
//                    new CountryDao() {Id = 230, Shortname = "GB", Name = "United Kingdom"},
//                    new CountryDao() {Id = 231, Shortname = "US", Name = "United States"},
//                    new CountryDao() {Id = 232, Shortname = "UM", Name = "United States Minor Outlying Islands"},
//                    new CountryDao() {Id = 233, Shortname = "UY", Name = "Uruguay"},
//                    new CountryDao() {Id = 234, Shortname = "UZ", Name = "Uzbekistan"},
//                    new CountryDao() {Id = 235, Shortname = "VU", Name = "Vanuatu"},
//                    new CountryDao() {Id = 236, Shortname = "VA", Name = "Vatican City State (Holy See)"},
//                    new CountryDao() {Id = 237, Shortname = "VE", Name = "Venezuela"},
//                    new CountryDao() {Id = 238, Shortname = "VN", Name = "Vietnam"},
//                    new CountryDao() {Id = 239, Shortname = "VG", Name = "Virgin Islands (British)"},
//                    new CountryDao() {Id = 240, Shortname = "VI", Name = "Virgin Islands (US)"},
//                    new CountryDao() {Id = 241, Shortname = "WF", Name = "Wallis And Futuna Islands"},
//                    new CountryDao() {Id = 242, Shortname = "EH", Name = "Western Sahara"},
//                    new CountryDao() {Id = 243, Shortname = "YE", Name = "Yemen"},
//                    new CountryDao() {Id = 244, Shortname = "YU", Name = "Yugoslavia"},
//                    new CountryDao() {Id = 245, Shortname = "ZM", Name = "Zambia"},
//                    new CountryDao() {Id = 246, Shortname = "ZW", Name = "Zimbabwe"}
//                );
//            }
//        }
//
//        private void CreateStates()
//        {
//            if (!_dbContext.States.Any())
//            {
//                _dbContext.States.AddRange(new StateDao {Id = 1, Name = "Alabama", Abbr = "AL"},
//                    new StateDao {Id = 2, Name = "Alaska", Abbr = "AK"},
//                    new StateDao {Id = 3, Name = "Arizona", Abbr = "AZ"},
//                    new StateDao {Id = 4, Name = "Arkansas", Abbr = "AR"},
//                    new StateDao {Id = 5, Name = "California", Abbr = "CA"},
//                    new StateDao {Id = 6, Name = "Colorado", Abbr = "CO"},
//                    new StateDao {Id = 7, Name = "Connecticut", Abbr = "CT"},
//                    new StateDao {Id = 8, Name = "Delaware", Abbr = "DE"},
//                    new StateDao {Id = 9, Name = "Florida", Abbr = "FL"},
//                    new StateDao {Id = 10, Name = "Georgia", Abbr = "GA"},
//                    new StateDao {Id = 11, Name = "Hawaii", Abbr = "HI"},
//                    new StateDao {Id = 12, Name = "Idaho", Abbr = "ID"},
//                    new StateDao {Id = 13, Name = "Illinois", Abbr = "IL"},
//                    new StateDao {Id = 14, Name = "Indiana", Abbr = "IN"},
//                    new StateDao {Id = 15, Name = "Iowa", Abbr = "IA"},
//                    new StateDao {Id = 16, Name = "Kansas", Abbr = "KS"},
//                    new StateDao {Id = 17, Name = "Kentucky", Abbr = "KY"},
//                    new StateDao {Id = 18, Name = "Louisiana", Abbr = "LA"},
//                    new StateDao {Id = 19, Name = "Maine", Abbr = "ME"},
//                    new StateDao {Id = 20, Name = "Maryland", Abbr = "MD"},
//                    new StateDao {Id = 21, Name = "Massachusetts", Abbr = "MA"},
//                    new StateDao {Id = 22, Name = "Michigan", Abbr = "MI"},
//                    new StateDao {Id = 23, Name = "Minnesota", Abbr = "MN"},
//                    new StateDao {Id = 24, Name = "Missouri", Abbr = "MO"},
//                    new StateDao {Id = 25, Name = "Mississippi", Abbr = "MS"},
//                    new StateDao {Id = 26, Name = "Montana", Abbr = "MT"},
//                    new StateDao {Id = 27, Name = "Nebraska", Abbr = "NE"},
//                    new StateDao {Id = 28, Name = "Nevada", Abbr = "NV"},
//                    new StateDao {Id = 29, Name = "New Hampshire", Abbr = "NH"},
//                    new StateDao {Id = 30, Name = "New Jersey", Abbr = "NJ"},
//                    new StateDao {Id = 31, Name = "New Mexico", Abbr = "NM"},
//                    new StateDao {Id = 32, Name = "New York", Abbr = "NY"},
//                    new StateDao {Id = 33, Name = "North Carolina", Abbr = "NC"},
//                    new StateDao {Id = 34, Name = "North Dakota", Abbr = "ND"},
//                    new StateDao {Id = 35, Name = "Ohio", Abbr = "OH"},
//                    new StateDao {Id = 36, Name = "Oklahoma", Abbr = "OK"},
//                    new StateDao {Id = 37, Name = "Oregon", Abbr = "OR"},
//                    new StateDao {Id = 38, Name = "Pennsylvania", Abbr = "PA"},
//                    new StateDao {Id = 39, Name = "Rhode Island", Abbr = "RI"},
//                    new StateDao {Id = 40, Name = "South Carolina", Abbr = "SC"},
//                    new StateDao {Id = 41, Name = "South Dakota", Abbr = "SD"},
//                    new StateDao {Id = 42, Name = "Tennessee", Abbr = "TN"},
//                    new StateDao {Id = 43, Name = "Texas", Abbr = "TX"},
//                    new StateDao {Id = 44, Name = "Utah", Abbr = "UT"},
//                    new StateDao {Id = 45, Name = "Virginia", Abbr = "VA"},
//                    new StateDao {Id = 46, Name = "Vermont", Abbr = "VT"},
//                    new StateDao {Id = 47, Name = "Washington DC", Abbr = "DC"},
//                    new StateDao {Id = 48, Name = "Washington", Abbr = "WA"},
//                    new StateDao {Id = 49, Name = "West Virginia", Abbr = "WV"},
//                    new StateDao {Id = 50, Name = "Wisconsin", Abbr = "WI"},
//                    new StateDao {Id = 51, Name = "Wyoming", Abbr = "WY"},
//                    new StateDao {Id = 52, Name = "Guam", Abbr = "GU"},
//                    new StateDao {Id = 53, Name = "Northern Mariana Islands", Abbr = "MP"},
//                    new StateDao {Id = 54, Name = "Virgin Islands", Abbr = "VI"},
//                    new StateDao {Id = 55, Name = "Puerto Rico", Abbr = "PR"},
//                    new StateDao {Id = 56, Name = "Marshall Islands", Abbr = "MH"},
//                    new StateDao {Id = 57, Name = "American Samoa", Abbr = "AS"},
//                    new StateDao {Id = 58, Name = "Armed Forces Africa", Abbr = "AE"},
//                    new StateDao {Id = 59, Name = "Federated States of Micronesia", Abbr = "FM"},
//                    new StateDao {Id = 60, Name = "Palau", Abbr = "PW"},
//                    new StateDao {Id = 61, Name = "Armed Forces Pacific", Abbr = "AP"},
//                    new StateDao {Id = 62, Name = "Armed Forces Americas", Abbr = "AA"});
//            }
//        }
//
//        private void CreateAreaOfInterests()
//        {
//            if (!_dbContext.AreaOfInterests.Any())
//            {
//                _dbContext.AreaOfInterests.AddRange(
//                    new AreaOfInterestDao {Id = 1, Name = "Business"},
//                    new AreaOfInterestDao {Id = 2, Name = "Computers"},
//                    new AreaOfInterestDao {Id = 3, Name = "Criminal Justice"},
//                    new AreaOfInterestDao {Id = 4, Name = "Culinary & Hospitality"},
//                    new AreaOfInterestDao {Id = 5, Name = "Design"},
//                    new AreaOfInterestDao {Id = 6, Name = "Education"},
//                    new AreaOfInterestDao {Id = 7, Name = "Goverment"},
//                    new AreaOfInterestDao {Id = 8, Name = "Health"},
//                    new AreaOfInterestDao {Id = 9, Name = "Liberal Arts"},
//                    new AreaOfInterestDao {Id = 10, Name = "Psychology"},
//                    new AreaOfInterestDao {Id = 11, Name = "Trades"},
//                    new AreaOfInterestDao {Id = 12, Name = "Science&Engineering"});
//            }
//        }
//
//        private void CreateEducationLevels()
//        {
//            if (!_dbContext.EducationLevels.Any())
//            {
//                _dbContext.EducationLevels.AddRange(
//                    new EducationLevelDao{Id = 1, Name = "hsdiploma"},
//                    new EducationLevelDao{Id = 2, Name = "ged"},
//                    new EducationLevelDao{Id = 3, Name = "college1"},
//                    new EducationLevelDao{Id = 4, Name = "associates"},
//                    new EducationLevelDao{Id = 5, Name = "bachelors"},
//                    new EducationLevelDao{Id = 6, Name = "masters"},
//                    new EducationLevelDao{Id = 7, Name = "doctorate"});
//            }
//        }
    }
}