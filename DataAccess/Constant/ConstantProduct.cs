using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Constant
{
    public class ConstantLists
    {

        //For RoleType=========================================
        private const string Admin = "Admin";
        private const string AdminValue = "1";

        private const string User = "User";
        private const string UserValue = "2";

        private const string Supervisor = "Supervisor";
        private const string SupervisorValue = "3";


        //For RoleType=========================================
        private const string Daily = "Daily";
        private const string DailyValue = "Daily";

        private const string Monthly = "Monthly";
        private const string MonthlyValue = "Monthly";

        private const string Yearly = "Yearly";
        private const string YearlyValue = "Yearly";


        //Measuring Unit

        //private const string meter = "Meter";
        //private const string MeterValue = "1";

        //private const string meter = "Meter";
        //private const string MeterValue = "1";

        //private const string meter = "Meter";
        //private const string MeterValue = "1";

        //private const string meter = "Meter";
        //private const string MeterValue = "1";

        //private const string meter = "Meter";
        //private const string MeterValue = "1";


        //Sms Frequency==================================================
        private const string Hourly = "Hourly";
        private const string HourlyValue = "1";

        private const string FDaily = "Daily";
        private const string FDailyValue = "2";

        private const string AlternateDay = "Alternate Day";
        private const string AlternateDayValue = "3";

        private const string TwiceaWeek = "Twice a Week";
        private const string TwiceaWeekValue = "4";

        private const string Weekly = "Weekly";
        private const string WeeklyValue = "5";

        private const string Fortnight = "Fortnight ";
        private const string FortnightValue = "6";

        private const string FMonthly = "Monthly";
        private const string FMonthlyValue = "7";



        //Seasons==================================================
        private const string Summer = "Summer";
        private const string SummerValue = "1";

        private const string Spring = "Spring";
        private const string SpringValue = "2";

        private const string Autumn = "Autumn";
        private const string AutumnValue = "3";

        private const string Winter = "Winter";
        private const string WinterValue = "4";

        //Vehicle Type==============================================

        private const string Truck = "Truck";
        private const string TruckValue = "1";

        private const string Car = "Car";
        private const string CarValue = "2";

        private const string Bus = "Bus";
        private const string BusValue = "3";

        private const string SUV = "SUV";
        private const string SUVValue = "4";

        //Area Units=================================================

        //private const string squareMile = "Square mile";
        //private const string squareMileValue = "2";

        private const string Bigha = "Bigha";
        private const string BighaValue = "1";

        private const string hectare = "Hectare";
        private const string hectareValue = "2";

        //private const string squareInch = "Square inch";
        //private const string squareInchValue = "3";

        //private const string squareYard = "Square yard";
        //private const string squareYardValue = "4";

        private const string squareFoot = "square foot";
        private const string squareFootValue = "5";

        private const string acre = "Acre";
        private const string acreValue = "6";

        //private const string  squareNauticalMile = "Square nautical mile";
        //private const string  squareNauticalMileValue = "7";


        //Weight Unit===========================================================

        private const string Kilogram = "Kilogram";
        private const string KilogramValue = "1";


        private const string Quintal = "Quintal";
        private const string QuintalValue = "2";

        //private const string Ton = "Ton";
        //private const string TonValue = "3";

        private const string MatricTon = "Matric Ton";
        private const string MatricTonValue = "4";

        //Order Status============================================================


        //Order Status 
        private const string Pending = "Pending";
        private const string PendingValue = "1";

        private const string Delivered = "Delivered";
        private const string DeliveredValue = "2";

        private const string InProgress = "InProgress";
        private const string InProgressValue = "3";

        private const string Cancel = "Cancel";
        private const string CancelValue = "4";



        public string Text
        {
            get;
            set;

        }
        public string Value
        {
            get;
            set;
            
        }

        public static List<ConstantLists> OrderStatus()
        {

            List<ConstantLists> Status = new List<ConstantLists>();
            ConstantLists status1 = new ConstantLists();
            status1.Text = Pending;
            status1.Value = PendingValue;
            Status.Add(status1);


            ConstantLists status2 = new ConstantLists();
            status2.Text = Delivered;
            status2.Value = DeliveredValue;
            Status.Add(status2);


            ConstantLists status3 = new ConstantLists();
            status3.Text = InProgress;
            status3.Value = InProgressValue;
            Status.Add(status3);


            ConstantLists status4 = new ConstantLists();
            status4.Text = Cancel;
            status4.Value = CancelValue;
            Status.Add(status4);

            return Status;

        }

        public static IEnumerable<ConstantLists> AreaUnitList()
        {
            List<ConstantLists> List = new List<ConstantLists>();

          

            ConstantLists obj1 = new ConstantLists();
            obj1.Text = Bigha;
            obj1.Value = BighaValue;
            List.Add(obj1);

            ConstantLists obj2 = new ConstantLists();
            obj2.Text = hectare;
            obj2.Value = hectareValue;
            List.Add(obj2);

            //ConstantLists obj3 = new ConstantLists();
            //obj3.Text = squareInch;
            //obj3.Value = squareInchValue;
            //List.Add(obj3);

            //ConstantLists obj4 = new ConstantLists();
            //obj4.Text = squareYard;
            //obj4.Value = squareYardValue;
            //List.Add(obj4);

            ConstantLists obj5 = new ConstantLists();
            obj5.Text = squareFoot;
            obj5.Value = squareFootValue;
            List.Add(obj5);

            ConstantLists obj6 = new ConstantLists();
            obj6.Text = acre;
            obj6.Value = acreValue;
            List.Add(obj6);

            //ConstantLists obj7 = new ConstantLists();
            //obj7.Text = squareNauticalMile;
            //obj7.Value = squareNauticalMileValue;
            //List.Add(obj7);

            return List;

        }

        public static IEnumerable<ConstantLists> WeightUnitList()
        {
            List<ConstantLists> List = new List<ConstantLists>();

            ConstantLists obj1 = new ConstantLists();
            obj1.Text = Kilogram;
            obj1.Value = KilogramValue;
            List.Add(obj1);

            ConstantLists obj2 = new ConstantLists();
            obj2.Text = Quintal;
            obj2.Value = QuintalValue;
            List.Add(obj2);

            //ConstantLists obj3 = new ConstantLists();
            //obj3.Text = Ton;
            //obj3.Value = TonValue;
            //List.Add(obj3);

            ConstantLists obj4 = new ConstantLists();
            obj4.Text = MatricTon;
            obj4.Value = MatricTonValue;
            List.Add(obj4);

            return List;

        }


        public static IEnumerable<ConstantLists> SmsFrequency()
        {
            List<ConstantLists> GenList = new List<ConstantLists>();

            ConstantLists objRateType = new ConstantLists();
            objRateType.Text = Hourly;
            objRateType.Value = HourlyValue;
            GenList.Add(objRateType);

            ConstantLists objRateType1 = new ConstantLists();
            objRateType1.Text = FDaily;
            objRateType1.Value = FDailyValue;
            GenList.Add(objRateType1);

            ConstantLists objRateType2 = new ConstantLists();
            objRateType2.Text = AlternateDay;
            objRateType2.Value = AlternateDayValue;
            GenList.Add(objRateType2);

            ConstantLists objRateType3 = new ConstantLists();
            objRateType3.Text = TwiceaWeek;
            objRateType3.Value = TwiceaWeekValue;
            GenList.Add(objRateType3);

            ConstantLists objRateType4 = new ConstantLists();
            objRateType4.Text = Weekly;
            objRateType4.Value = WeeklyValue;
            GenList.Add(objRateType4);

            ConstantLists objRateType5 = new ConstantLists();
            objRateType5.Text = Fortnight;
            objRateType5.Value = FortnightValue;
            GenList.Add(objRateType5);

            ConstantLists objRateType6 = new ConstantLists();
            objRateType6.Text = FMonthly;
            objRateType6.Value = FMonthlyValue;
            GenList.Add(objRateType6);


            return GenList;

        }

        public static IEnumerable<ConstantLists> LaborRateType()
        {
            List<ConstantLists> GenList = new List<ConstantLists>();

            ConstantLists objRateType = new ConstantLists();
            objRateType.Text = Daily;
            objRateType.Value = DailyValue;
            GenList.Add(objRateType);

            ConstantLists objRateType1 = new ConstantLists();
            objRateType1.Text = Monthly;
            objRateType1.Value = MonthlyValue;
            GenList.Add(objRateType1);

            ConstantLists objRateType2 = new ConstantLists();
            objRateType2.Text = Yearly;
            objRateType2.Value = YearlyValue;
            GenList.Add(objRateType2);

            return GenList;
        
        }


        public static IEnumerable<ConstantLists> SaesonList()
        {
            List<ConstantLists> List = new List<ConstantLists>();

            ConstantLists obj1 = new ConstantLists();
            obj1.Text = Summer;
            obj1.Value = SummerValue;
            List.Add(obj1);

            ConstantLists obj2 = new ConstantLists();
            obj2.Text = Spring;
            obj2.Value = SpringValue;
            List.Add(obj2);

            ConstantLists obj3 = new ConstantLists();
            obj3.Text = Autumn;
            obj3.Value = AutumnValue;
            List.Add(obj3);

            ConstantLists obj4 = new ConstantLists();
            obj4.Text = Winter;
            obj4.Value = WinterValue;
            List.Add(obj4);

            return List;

        }

        public static IEnumerable<ConstantLists> VehicleList()
        {
            List<ConstantLists> List = new List<ConstantLists>();

            ConstantLists obj1 = new ConstantLists();
            obj1.Text = Truck;
            obj1.Value = TruckValue;
            List.Add(obj1);

            ConstantLists obj2 = new ConstantLists();
            obj2.Text = Car;
            obj2.Value = CarValue;
            List.Add(obj2);

            ConstantLists obj3 = new ConstantLists();
            obj3.Text = Bus;
            obj3.Value = BusValue;
            List.Add(obj3);

            ConstantLists obj4 = new ConstantLists();
            obj4.Text = SUV;
            obj4.Value = SUVValue;
            List.Add(obj4);

            return List;

        }


        public static IEnumerable<ConstantLists> UserSalaryType()
        {
            List<ConstantLists> GenList = new List<ConstantLists>();

            ConstantLists objRateType1 = new ConstantLists();
            objRateType1.Text = Monthly;
            objRateType1.Value = MonthlyValue;
            GenList.Add(objRateType1);

            ConstantLists objRateType2 = new ConstantLists();
            objRateType2.Text = Yearly;
            objRateType2.Value = YearlyValue;
            GenList.Add(objRateType2);

            return GenList;

        }


        public static IEnumerable<ConstantLists> RoleList()
        {
            List<ConstantLists> List = new List<ConstantLists>();

            ConstantLists obj1 = new ConstantLists();
            obj1.Text = Admin;
            obj1.Value = AdminValue;
            List.Add(obj1);

            ConstantLists obj2 = new ConstantLists();
            obj2.Text = User;
            obj2.Value = UserValue;
            List.Add(obj2);

            ConstantLists obj3 = new ConstantLists();
            obj3.Text = Supervisor;
            obj3.Value = SupervisorValue;
            List.Add(obj3);

            return List;

        }


        public static IEnumerable<ConstantLists> WorkList()
        {
            List<ConstantLists> List = new List<ConstantLists>();

            List.Add(new ConstantLists { Text = "Field-area", Value = "1" });

            List.Add(new ConstantLists { Text = "Office", Value = "2" });

            return List;
        }
    }


    public class StateList
    {
        public int StateId { get; set; }
        public string StateName { get; set; }

        public static List<StateList> GetAllStates()
        {
            return new List<StateList> {
                new StateList { StateId = 1, StateName = "Andaman and Nicobar Islands" },
                new StateList { StateId = 2, StateName = "Andhra Pradesh" },
                new StateList { StateId = 3, StateName = "Arunachal Pradesh" },
                new StateList { StateId = 4, StateName = "Assam" },
                new StateList { StateId = 6, StateName = "Bihar" },
                new StateList { StateId = 7, StateName = "Chandigarh" },
                new StateList { StateId = 8, StateName = "Chhattisgarh" },
                new StateList { StateId = 9, StateName = "Delhi" },
                new StateList { StateId = 10, StateName = "Goa" },
                new StateList { StateId = 11, StateName = "Gujarat" },
                new StateList { StateId = 12, StateName = "Haryana" },
                new StateList { StateId = 13, StateName = "Himachal Pradesh" },
                new StateList { StateId = 14, StateName = "Jammu and Kashmir" },
                new StateList { StateId = 15, StateName = "Jharkhand" },
                new StateList { StateId = 16, StateName = "Karnataka" },
                new StateList { StateId = 17, StateName = "Kerala" },
                new StateList { StateId = 18, StateName = "Madhya Pradesh" },
                new StateList { StateId = 19, StateName = "Maharashtra" },
                new StateList { StateId = 20, StateName = "Manipur" },
                new StateList { StateId = 21, StateName = "Meghalaya" },
                new StateList { StateId = 22, StateName = "Mizoram" },
                new StateList { StateId = 23, StateName = "Nagaland" },
                new StateList { StateId = 24, StateName = "Orissa" },
                new StateList { StateId = 25, StateName = "Pondicherry" },
                new StateList { StateId = 26, StateName = "Punjab" },
                new StateList { StateId = 27, StateName = "Rajasthan" },
                new StateList { StateId = 28, StateName = "Tamil Nadu" },
                new StateList { StateId = 29, StateName = "Tripura" },
                new StateList { StateId = 30, StateName = "Uttar Pradesh" },
                new StateList { StateId = 31, StateName = "Uttaranchal" },
                new StateList { StateId = 32, StateName = "West Bengal" },

            };
        }

        public static string GetStateName(int StateId)
        {
            return GetAllStates().FirstOrDefault(x => x.StateId == StateId).StateName;
        }
    }

    
    public class CityList
    {
        public int CityId { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }

        public static List<CityList> AllCities()
        {
            return new List<CityList> {
                new CityList { CityId = 1, StateId = 1, CityName = "Port Blair" },
                new CityList { CityId = 2, StateId = 2, CityName = "Adilabad" },
                new CityList { CityId = 3, StateId = 2, CityName = "Adoni" },
                new CityList { CityId = 4, StateId = 2, CityName = "Alwal" },
                new CityList { CityId = 5, StateId = 2, CityName = "Anakapalle" },
                new CityList { CityId = 6, StateId = 2, CityName = "Anantapur" },
                new CityList { CityId = 7, StateId = 2, CityName = "Bapatla" },
                new CityList { CityId = 8, StateId = 2, CityName = "Belampalli" },
                new CityList { CityId = 9, StateId = 2, CityName = "Bhimavaram" },
                new CityList { CityId = 10, StateId = 2, CityName = "Bhongir" },
                new CityList { CityId = 11, StateId = 2, CityName = "Bobbili" },
                new CityList { CityId = 12, StateId = 2, CityName = "Bodhan" },
                new CityList { CityId = 13, StateId = 2, CityName = "Chilakalurupet" },
                new CityList { CityId = 14, StateId = 2, CityName = "Chinna Chawk" },
                new CityList { CityId = 15, StateId = 2, CityName = "Chirala" },
                new CityList { CityId = 16, StateId = 2, CityName = "Chittur" },
                new CityList { CityId = 17, StateId = 2, CityName = "Cuddapah" },
                new CityList { CityId = 18, StateId = 2, CityName = "Dharmavaram" },
                new CityList { CityId = 19, StateId = 2, CityName = "Dhone" },
                new CityList { CityId = 20, StateId = 2, CityName = "Eluru" },
                new CityList { CityId = 21, StateId = 2, CityName = "Gaddiannaram" },
                new CityList { CityId = 22, StateId = 2, CityName = "Gadwal" },
                new CityList { CityId = 23, StateId = 2, CityName = "Gajuwaka" },
                new CityList { CityId = 24, StateId = 2, CityName = "Gudivada" },
                new CityList { CityId = 25, StateId = 2, CityName = "Gudur" },
                new CityList { CityId = 26, StateId = 2, CityName = "Guntakal" },
                new CityList { CityId = 27, StateId = 2, CityName = "Guntur" },
                new CityList { CityId = 28, StateId = 2, CityName = "Hindupur" },
                new CityList { CityId = 29, StateId = 2, CityName = "Hyderabad" },
                new CityList { CityId = 30, StateId = 2, CityName = "Jagtial" },
                new CityList { CityId = 31, StateId = 2, CityName = "Kadiri" },
                new CityList { CityId = 32, StateId = 2, CityName = "Kagaznagar" },
                new CityList { CityId = 33, StateId = 2, CityName = "Kakinada" },
                new CityList { CityId = 34, StateId = 2, CityName = "Kallur" },
                new CityList { CityId = 35, StateId = 2, CityName = "Kamareddi" },
                new CityList { CityId = 36, StateId = 2, CityName = "Kapra" },
                new CityList { CityId = 37, StateId = 2, CityName = "Karimnagar" },
                new CityList { CityId = 38, StateId = 2, CityName = "Karnul" },
                new CityList { CityId = 39, StateId = 2, CityName = "Kavali" },
                new CityList { CityId = 40, StateId = 2, CityName = "Khammam" },
                new CityList { CityId = 41, StateId = 2, CityName = "Kodar" },
                new CityList { CityId = 42, StateId = 2, CityName = "Kondukur" },
                new CityList { CityId = 43, StateId = 2, CityName = "Koratla" },
                new CityList { CityId = 44, StateId = 2, CityName = "Kottagudem" },
                new CityList { CityId = 45, StateId = 2, CityName = "Kukatpalle" },
                new CityList { CityId = 46, StateId = 2, CityName = "Lalbahadur Nagar" },
                new CityList { CityId = 47, StateId = 2, CityName = "Machilipatnam" },
                new CityList { CityId = 48, StateId = 2, CityName = "Mahbubnagar" },
                new CityList { CityId = 49, StateId = 2, CityName = "Malkajgiri" },
                new CityList { CityId = 50, StateId = 2, CityName = "Mancheral" },
                new CityList { CityId = 51, StateId = 2, CityName = "Mandamarri" },
                new CityList { CityId = 52, StateId = 2, CityName = "Mangalagiri" },
                new CityList { CityId = 53, StateId = 2, CityName = "Markapur" },
                new CityList { CityId = 54, StateId = 2, CityName = "Miryalaguda" },
                new CityList { CityId = 55, StateId = 2, CityName = "Nalgonda" },
                new CityList { CityId = 56, StateId = 2, CityName = "Nandyal" },
                new CityList { CityId = 57, StateId = 2, CityName = "Narasapur" },
                new CityList { CityId = 58, StateId = 2, CityName = "Narasaraopet" },
                new CityList { CityId = 59, StateId = 2, CityName = "Nellur" },
                new CityList { CityId = 60, StateId = 2, CityName = "Nirmal" },
                new CityList { CityId = 61, StateId = 2, CityName = "Nizamabad" },
                new CityList { CityId = 62, StateId = 2, CityName = "Nuzvid" },
                new CityList { CityId = 63, StateId = 2, CityName = "Ongole" },
                new CityList { CityId = 64, StateId = 2, CityName = "Palakollu" },
                new CityList { CityId = 65, StateId = 2, CityName = "Palasa" },
                new CityList { CityId = 66, StateId = 2, CityName = "Palwancha" },
                new CityList { CityId = 67, StateId = 2, CityName = "Patancheru" },
                new CityList { CityId = 68, StateId = 2, CityName = "Piduguralla" },
                new CityList { CityId = 69, StateId = 2, CityName = "Ponnur" },
                new CityList { CityId = 70, StateId = 2, CityName = "Proddatur" },
                new CityList { CityId = 71, StateId = 2, CityName = "Qutubullapur" },
                new CityList { CityId = 72, StateId = 2, CityName = "Rajamahendri" },
                new CityList { CityId = 73, StateId = 2, CityName = "Rajampet" },
                new CityList { CityId = 74, StateId = 2, CityName = "Rajendranagar" },
                new CityList { CityId = 75, StateId = 2, CityName = "Ramachandrapuram" },
                new CityList { CityId = 76, StateId = 2, CityName = "Ramagundam" },
                new CityList { CityId = 77, StateId = 2, CityName = "Rayachoti" },
                new CityList { CityId = 78, StateId = 2, CityName = "Rayadrug" },
                new CityList { CityId = 79, StateId = 2, CityName = "Samalkot" },
                new CityList { CityId = 80, StateId = 2, CityName = "Sangareddi" },
                new CityList { CityId = 81, StateId = 2, CityName = "Sattenapalle" },
                new CityList { CityId = 82, StateId = 2, CityName = "Serilungampalle" },
                new CityList { CityId = 83, StateId = 2, CityName = "Siddipet" },
                new CityList { CityId = 84, StateId = 2, CityName = "Sikandarabad" },
                new CityList { CityId = 85, StateId = 2, CityName = "Sirsilla" },
                new CityList { CityId = 86, StateId = 2, CityName = "Srikakulam" },
                new CityList { CityId = 87, StateId = 2, CityName = "Srikalahasti" },
                new CityList { CityId = 88, StateId = 2, CityName = "Suriapet" },
                new CityList { CityId = 89, StateId = 2, CityName = "Tadepalle" },
                new CityList { CityId = 90, StateId = 2, CityName = "Tadepallegudem" },
                new CityList { CityId = 91, StateId = 2, CityName = "Tadpatri" },
                new CityList { CityId = 92, StateId = 2, CityName = "Tandur" },
                new CityList { CityId = 93, StateId = 2, CityName = "Tanuku" },
                new CityList { CityId = 94, StateId = 2, CityName = "Tenali" },
                new CityList { CityId = 95, StateId = 2, CityName = "Tirupati" },
                new CityList { CityId = 96, StateId = 2, CityName = "Tuni" },
                new CityList { CityId = 97, StateId = 2, CityName = "Uppal Kalan" },
                new CityList { CityId = 98, StateId = 2, CityName = "Vijayawada" },
                new CityList { CityId = 99, StateId = 2, CityName = "Vinukonda" },
                new CityList { CityId = 100, StateId = 2, CityName = "Visakhapatnam" },
                new CityList { CityId = 101, StateId = 2, CityName = "Vizianagaram" },
                new CityList { CityId = 102, StateId = 2, CityName = "Vuyyuru" },
                new CityList { CityId = 103, StateId = 2, CityName = "Wanparti" },
                new CityList { CityId = 104, StateId = 2, CityName = "Warangal" },
                new CityList { CityId = 105, StateId = 2, CityName = "Yemmiganur" },
                new CityList { CityId = 106, StateId = 3, CityName = "Itanagar" },
                new CityList { CityId = 107, StateId = 4, CityName = "Barpeta" },
                new CityList { CityId = 108, StateId = 4, CityName = "Bongaigaon" },
                new CityList { CityId = 109, StateId = 4, CityName = "Dhuburi" },
                new CityList { CityId = 110, StateId = 4, CityName = "Dibrugarh" },
                new CityList { CityId = 111, StateId = 4, CityName = "Diphu" },
                new CityList { CityId = 112, StateId = 4, CityName = "Guwahati" },
                new CityList { CityId = 113, StateId = 4, CityName = "Jorhat" },
                new CityList { CityId = 114, StateId = 4, CityName = "Karimganj" },
                new CityList { CityId = 115, StateId = 4, CityName = "Lakhimpur" },
                new CityList { CityId = 116, StateId = 4, CityName = "Lanka" },
                new CityList { CityId = 117, StateId = 4, CityName = "Nagaon" },
                new CityList { CityId = 118, StateId = 4, CityName = "Sibsagar" },
                new CityList { CityId = 119, StateId = 4, CityName = "Silchar" },
                new CityList { CityId = 120, StateId = 4, CityName = "Tezpur" },
                new CityList { CityId = 121, StateId = 4, CityName = "Tinsukia" },
                new CityList { CityId = 122, StateId = 5, CityName = "Alipur Duar" },
                new CityList { CityId = 123, StateId = 5, CityName = "Arambagh" },
                new CityList { CityId = 124, StateId = 5, CityName = "Asansol" },
                new CityList { CityId = 125, StateId = 5, CityName = "Ashoknagar Kalyangarh" },
                new CityList { CityId = 126, StateId = 5, CityName = "Baharampur" },
                new CityList { CityId = 127, StateId = 5, CityName = "Baidyabati" },
                new CityList { CityId = 128, StateId = 5, CityName = "Baj Baj" },
                new CityList { CityId = 129, StateId = 5, CityName = "Bally" },
                new CityList { CityId = 130, StateId = 5, CityName = "Bally Cantonment" },
                new CityList { CityId = 131, StateId = 5, CityName = "Balurghat" },
                new CityList { CityId = 132, StateId = 5, CityName = "Bangaon" },
                new CityList { CityId = 133, StateId = 5, CityName = "Bankra" },
                new CityList { CityId = 134, StateId = 5, CityName = "Bankura" },
                new CityList { CityId = 135, StateId = 5, CityName = "Bansbaria" },
                new CityList { CityId = 136, StateId = 5, CityName = "Baranagar" },
                new CityList { CityId = 137, StateId = 5, CityName = "Barddhaman" },
                new CityList { CityId = 138, StateId = 5, CityName = "Basirhat" },
                new CityList { CityId = 139, StateId = 5, CityName = "Bhadreswar" },
                new CityList { CityId = 140, StateId = 5, CityName = "Bhatpara" },
                new CityList { CityId = 141, StateId = 5, CityName = "Bidhannagar" },
                new CityList { CityId = 142, StateId = 5, CityName = "Binnaguri" },
                new CityList { CityId = 143, StateId = 5, CityName = "Bishnupur" },
                new CityList { CityId = 144, StateId = 5, CityName = "Bolpur" },
                new CityList { CityId = 145, StateId = 5, CityName = "Calcutta" },
                new CityList { CityId = 146, StateId = 5, CityName = "Chakdaha" },
                new CityList { CityId = 147, StateId = 5, CityName = "Champdani" },
                new CityList { CityId = 148, StateId = 5, CityName = "Chandannagar" },
                new CityList { CityId = 149, StateId = 5, CityName = "Contai" },
                new CityList { CityId = 150, StateId = 5, CityName = "Dabgram" },
                new CityList { CityId = 151, StateId = 5, CityName = "Darjiling" },
                new CityList { CityId = 152, StateId = 5, CityName = "Dhulian" },
                new CityList { CityId = 153, StateId = 5, CityName = "Dinhata" },
                new CityList { CityId = 154, StateId = 5, CityName = "Dum Dum" },
                new CityList { CityId = 155, StateId = 5, CityName = "Durgapur" },
                new CityList { CityId = 156, StateId = 5, CityName = "Gangarampur" },
                new CityList { CityId = 157, StateId = 5, CityName = "Garulia" },
                new CityList { CityId = 158, StateId = 5, CityName = "Gayespur" },
                new CityList { CityId = 159, StateId = 5, CityName = "Ghatal" },
                new CityList { CityId = 160, StateId = 5, CityName = "Gopalpur" },
                new CityList { CityId = 161, StateId = 5, CityName = "Habra" },
                new CityList { CityId = 162, StateId = 5, CityName = "Halisahar" },
                new CityList { CityId = 163, StateId = 5, CityName = "Haora" },
                new CityList { CityId = 164, StateId = 5, CityName = "HugliChunchura" },
                new CityList { CityId = 165, StateId = 5, CityName = "Ingraj Bazar" },
                new CityList { CityId = 166, StateId = 5, CityName = "Islampur" },
                new CityList { CityId = 167, StateId = 5, CityName = "Jalpaiguri" },
                new CityList { CityId = 168, StateId = 5, CityName = "Jamuria" },
                new CityList { CityId = 169, StateId = 5, CityName = "Jangipur" },
                new CityList { CityId = 170, StateId = 5, CityName = "Jhargram" },
                new CityList { CityId = 171, StateId = 5, CityName = "Kaliyaganj" },
                new CityList { CityId = 172, StateId = 5, CityName = "Kalna" },
                new CityList { CityId = 173, StateId = 5, CityName = "Kalyani" },
                new CityList { CityId = 174, StateId = 5, CityName = "Kamarhati" },
                new CityList { CityId = 175, StateId = 5, CityName = "Kanchrapara" },
                new CityList { CityId = 176, StateId = 5, CityName = "Kandi" },
                new CityList { CityId = 177, StateId = 5, CityName = "Karsiyang" },
                new CityList { CityId = 178, StateId = 5, CityName = "Katwa" },
                new CityList { CityId = 179, StateId = 5, CityName = "Kharagpur" },
                new CityList { CityId = 180, StateId = 5, CityName = "Kharagpur Railway Settlement" },
                new CityList { CityId = 181, StateId = 5, CityName = "Khardaha" },
                new CityList { CityId = 182, StateId = 5, CityName = "Kharia" },
                new CityList { CityId = 183, StateId = 5, CityName = "Koch Bihar" },
                new CityList { CityId = 184, StateId = 5, CityName = "Konnagar" },
                new CityList { CityId = 185, StateId = 5, CityName = "Krishnanagar" },
                new CityList { CityId = 186, StateId = 5, CityName = "Kulti" },
                new CityList { CityId = 187, StateId = 5, CityName = "Madhyamgram" },
                new CityList { CityId = 188, StateId = 5, CityName = "Maheshtala" },
                new CityList { CityId = 189, StateId = 5, CityName = "Memari" },
                new CityList { CityId = 190, StateId = 5, CityName = "Midnapur" },
                new CityList { CityId = 191, StateId = 5, CityName = "Naihati" },
                new CityList { CityId = 192, StateId = 5, CityName = "Navadwip" },
                new CityList { CityId = 193, StateId = 5, CityName = "Ni Barakpur" },
                new CityList { CityId = 194, StateId = 5, CityName = "North Barakpur" },
                new CityList { CityId = 195, StateId = 5, CityName = "North Dum Dum" },
                new CityList { CityId = 196, StateId = 5, CityName = "Old Maldah" },
                new CityList { CityId = 197, StateId = 5, CityName = "Panihati" },
                new CityList { CityId = 198, StateId = 5, CityName = "Phulia" },
                new CityList { CityId = 199, StateId = 5, CityName = "Pujali" },
                new CityList { CityId = 200, StateId = 5, CityName = "Puruliya" },
                new CityList { CityId = 201, StateId = 5, CityName = "Raiganj" },
                new CityList { CityId = 202, StateId = 5, CityName = "Rajpur" },
                new CityList { CityId = 203, StateId = 5, CityName = "Rampur Hat" },
                new CityList { CityId = 204, StateId = 5, CityName = "Ranaghat" },
                new CityList { CityId = 205, StateId = 5, CityName = "Raniganj" },
                new CityList { CityId = 206, StateId = 5, CityName = "Rishra" },
                new CityList { CityId = 207, StateId = 5, CityName = "Shantipur" },
                new CityList { CityId = 208, StateId = 5, CityName = "Shiliguri" },
                new CityList { CityId = 209, StateId = 5, CityName = "Shrirampur" },
                new CityList { CityId = 210, StateId = 5, CityName = "Siuri" },
                new CityList { CityId = 211, StateId = 5, CityName = "South Dum Dum" },
                new CityList { CityId = 212, StateId = 5, CityName = "Titagarh" },
                new CityList { CityId = 213, StateId = 5, CityName = "Ulubaria" },
                new CityList { CityId = 214, StateId = 5, CityName = "UttarparaKotrung" },
                new CityList { CityId = 215, StateId = 6, CityName = "Araria" },
                new CityList { CityId = 216, StateId = 6, CityName = "Arrah" },
                new CityList { CityId = 217, StateId = 6, CityName = "Aurangabad" },
                new CityList { CityId = 218, StateId = 6, CityName = "Bagaha" },
                new CityList { CityId = 219, StateId = 6, CityName = "Begusarai" },
                new CityList { CityId = 220, StateId = 6, CityName = "Bettiah" },
                new CityList { CityId = 221, StateId = 6, CityName = "Bhabua" },
                new CityList { CityId = 222, StateId = 6, CityName = "Bhagalpur" },
                new CityList { CityId = 223, StateId = 6, CityName = "Bihar" },
                new CityList { CityId = 224, StateId = 6, CityName = "Buxar" },
                new CityList { CityId = 225, StateId = 6, CityName = "Chhapra" },
                new CityList { CityId = 226, StateId = 6, CityName = "Darbhanga" },
                new CityList { CityId = 227, StateId = 6, CityName = "Dehri" },
                new CityList { CityId = 228, StateId = 6, CityName = "DighaMainpura" },
                new CityList { CityId = 229, StateId = 6, CityName = "Dinapur" },
                new CityList { CityId = 230, StateId = 6, CityName = "Dumraon" },
                new CityList { CityId = 231, StateId = 6, CityName = "Gaya" },
                new CityList { CityId = 232, StateId = 6, CityName = "Gopalganj" },
                new CityList { CityId = 233, StateId = 6, CityName = "Goura" },
                new CityList { CityId = 234, StateId = 6, CityName = "Hajipur" },
                new CityList { CityId = 235, StateId = 6, CityName = "Jahanabad" },
                new CityList { CityId = 236, StateId = 6, CityName = "Jamalpur" },
                new CityList { CityId = 237, StateId = 6, CityName = "Jamui" },
                new CityList { CityId = 238, StateId = 6, CityName = "Katihar" },
                new CityList { CityId = 239, StateId = 6, CityName = "Khagaria" },
                new CityList { CityId = 240, StateId = 6, CityName = "Khagaul" },
                new CityList { CityId = 241, StateId = 6, CityName = "Kishanganj" },
                new CityList { CityId = 242, StateId = 6, CityName = "Lakhisarai" },
                new CityList { CityId = 243, StateId = 6, CityName = "Madhipura" },
                new CityList { CityId = 244, StateId = 6, CityName = "Madhubani" },
                new CityList { CityId = 245, StateId = 6, CityName = "Masaurhi" },
                new CityList { CityId = 246, StateId = 6, CityName = "Mokama" },
                new CityList { CityId = 247, StateId = 6, CityName = "Motihari" },
                new CityList { CityId = 248, StateId = 6, CityName = "Munger" },
                new CityList { CityId = 249, StateId = 6, CityName = "Muzaffarpur" },
                new CityList { CityId = 250, StateId = 6, CityName = "Nawada" },
                new CityList { CityId = 251, StateId = 6, CityName = "Patna" },
                new CityList { CityId = 252, StateId = 6, CityName = "Phulwari" },
                new CityList { CityId = 253, StateId = 6, CityName = "Purnia" },
                new CityList { CityId = 254, StateId = 6, CityName = "Raxaul" },
                new CityList { CityId = 255, StateId = 6, CityName = "Saharsa" },
                new CityList { CityId = 256, StateId = 6, CityName = "Samastipur" },
                new CityList { CityId = 257, StateId = 6, CityName = "Sasaram" },
                new CityList { CityId = 258, StateId = 6, CityName = "Sitamarhi" },
                new CityList { CityId = 259, StateId = 6, CityName = "Siwan" },
                new CityList { CityId = 260, StateId = 6, CityName = "Supaul" },
                new CityList { CityId = 261, StateId = 7, CityName = "Chandigarh" },
                new CityList { CityId = 262, StateId = 8, CityName = "Ambikapur" },
                new CityList { CityId = 263, StateId = 8, CityName = "Bhilai" },
                new CityList { CityId = 264, StateId = 8, CityName = "Bilaspur" },
                new CityList { CityId = 265, StateId = 8, CityName = "Charoda" },
                new CityList { CityId = 266, StateId = 8, CityName = "Chirmiri" },
                new CityList { CityId = 267, StateId = 8, CityName = "Dhamtari" },
                new CityList { CityId = 268, StateId = 8, CityName = "Durg" },
                new CityList { CityId = 269, StateId = 8, CityName = "Jagdalpur" },
                new CityList { CityId = 270, StateId = 8, CityName = "Korba" },
                new CityList { CityId = 271, StateId = 8, CityName = "Raigarh" },
                new CityList { CityId = 272, StateId = 8, CityName = "Raipur" },
                new CityList { CityId = 273, StateId = 8, CityName = "Rajnandgaon" },
                new CityList { CityId = 274, StateId = 9, CityName = "Bhalswa Jahangirpur" },
                new CityList { CityId = 275, StateId = 9, CityName = "Burari" },
                new CityList { CityId = 276, StateId = 9, CityName = "Chilla Saroda Bangar" },
                new CityList { CityId = 277, StateId = 9, CityName = "Dallo Pura" },
                new CityList { CityId = 278, StateId = 9, CityName = "Delhi" },
                new CityList { CityId = 279, StateId = 9, CityName = "Deoli" },
                new CityList { CityId = 280, StateId = 9, CityName = "Dilli Cantonment" },
                new CityList { CityId = 281, StateId = 9, CityName = "Gharoli" },
                new CityList { CityId = 282, StateId = 9, CityName = "Gokalpur" },
                new CityList { CityId = 283, StateId = 9, CityName = "Hastsal" },
                new CityList { CityId = 284, StateId = 9, CityName = "Jaffrabad" },
                new CityList { CityId = 285, StateId = 9, CityName = "Karawal Nagar" },
                new CityList { CityId = 286, StateId = 9, CityName = "Khajuri Khas" },
                new CityList { CityId = 287, StateId = 9, CityName = "Kirari Suleman Nagar" },
                new CityList { CityId = 288, StateId = 9, CityName = "Mandoli" },
                new CityList { CityId = 289, StateId = 9, CityName = "Mithe Pur" },
                new CityList { CityId = 290, StateId = 9, CityName = "Molarband" },
                new CityList { CityId = 291, StateId = 9, CityName = "Mundka" },
                new CityList { CityId = 292, StateId = 9, CityName = "Mustafabad" },
                new CityList { CityId = 293, StateId = 9, CityName = "Nangloi Jat" },
                new CityList { CityId = 294, StateId = 9, CityName = "Ni Dilli" },
                new CityList { CityId = 295, StateId = 9, CityName = "Pul Pehlad" },
                new CityList { CityId = 296, StateId = 9, CityName = "Puth Kalan" },
                new CityList { CityId = 297, StateId = 9, CityName = "Roshan Pura" },
                new CityList { CityId = 298, StateId = 9, CityName = "Sadat Pur Gujran" },
                new CityList { CityId = 299, StateId = 9, CityName = "Sultanpur Majra" },
                new CityList { CityId = 300, StateId = 9, CityName = "Tajpul" },
                new CityList { CityId = 301, StateId = 9, CityName = "Tigri" },
                new CityList { CityId = 302, StateId = 9, CityName = "Ziauddin Pur" },
                new CityList { CityId = 303, StateId = 10, CityName = "Madgaon" },
                new CityList { CityId = 304, StateId = 10, CityName = "Mormugao" },
                new CityList { CityId = 305, StateId = 10, CityName = "Panaji" },
                new CityList { CityId = 306, StateId = 11, CityName = "Ahmadabad" },
                new CityList { CityId = 307, StateId = 11, CityName = "Amreli" },
                new CityList { CityId = 308, StateId = 11, CityName = "Anand" },
                new CityList { CityId = 309, StateId = 11, CityName = "Anjar" },
                new CityList { CityId = 310, StateId = 11, CityName = "Bardoli" },
                new CityList { CityId = 311, StateId = 11, CityName = "Bharuch" },
                new CityList { CityId = 312, StateId = 11, CityName = "Bhavnagar" },
                new CityList { CityId = 313, StateId = 11, CityName = "Bhuj" },
                new CityList { CityId = 314, StateId = 11, CityName = "Borsad" },
                new CityList { CityId = 315, StateId = 11, CityName = "Botad" },
                new CityList { CityId = 316, StateId = 11, CityName = "Chandkheda" },
                new CityList { CityId = 317, StateId = 11, CityName = "Chandlodiya" },
                new CityList { CityId = 318, StateId = 11, CityName = "Dabhoi" },
                new CityList { CityId = 319, StateId = 11, CityName = "Dahod" },
                new CityList { CityId = 320, StateId = 11, CityName = "Dholka" },
                new CityList { CityId = 321, StateId = 11, CityName = "Dhoraji" },
                new CityList { CityId = 322, StateId = 11, CityName = "Dhrangadhra" },
                new CityList { CityId = 323, StateId = 11, CityName = "Disa" },
                new CityList { CityId = 324, StateId = 11, CityName = "Gandhidham" },
                new CityList { CityId = 325, StateId = 11, CityName = "Gandhinagar" },
                new CityList { CityId = 326, StateId = 11, CityName = "Ghatlodiya" },
                new CityList { CityId = 327, StateId = 11, CityName = "Godhra" },
                new CityList { CityId = 328, StateId = 11, CityName = "Gondal" },
                new CityList { CityId = 329, StateId = 11, CityName = "Himatnagar" },
                new CityList { CityId = 330, StateId = 11, CityName = "Jamnagar" },
                new CityList { CityId = 331, StateId = 11, CityName = "Jamnagar" },
                new CityList { CityId = 332, StateId = 11, CityName = "Jetpur" },
                new CityList { CityId = 333, StateId = 11, CityName = "Junagadh" },
                new CityList { CityId = 334, StateId = 11, CityName = "Kalol" },
                new CityList { CityId = 335, StateId = 11, CityName = "Keshod" },
                new CityList { CityId = 336, StateId = 11, CityName = "Khambhat" },
                new CityList { CityId = 337, StateId = 11, CityName = "Kundla" },
                new CityList { CityId = 338, StateId = 11, CityName = "Mahuva" },
                new CityList { CityId = 339, StateId = 11, CityName = "Mangrol" },
                new CityList { CityId = 340, StateId = 11, CityName = "Modasa" },
                new CityList { CityId = 341, StateId = 11, CityName = "Morvi" },
                new CityList { CityId = 342, StateId = 11, CityName = "Nadiad" },
                new CityList { CityId = 343, StateId = 11, CityName = "Navagam Ghed" },
                new CityList { CityId = 344, StateId = 11, CityName = "Navsari" },
                new CityList { CityId = 345, StateId = 11, CityName = "Palitana" },
                new CityList { CityId = 346, StateId = 11, CityName = "Patan" },
                new CityList { CityId = 347, StateId = 11, CityName = "Porbandar" },
                new CityList { CityId = 348, StateId = 11, CityName = "Puna" },
                new CityList { CityId = 349, StateId = 11, CityName = "Rajkot" },
                new CityList { CityId = 350, StateId = 11, CityName = "Ramod" },
                new CityList { CityId = 351, StateId = 11, CityName = "Ranip" },
                new CityList { CityId = 352, StateId = 11, CityName = "Siddhapur" },
                new CityList { CityId = 353, StateId = 11, CityName = "Sihor" },
                new CityList { CityId = 354, StateId = 11, CityName = "Surat" },
                new CityList { CityId = 355, StateId = 11, CityName = "Surendranagar" },
                new CityList { CityId = 356, StateId = 11, CityName = "Thaltej" },
                new CityList { CityId = 357, StateId = 11, CityName = "Una" },
                new CityList { CityId = 358, StateId = 11, CityName = "Unjha" },
                new CityList { CityId = 359, StateId = 11, CityName = "Upleta" },
                new CityList { CityId = 360, StateId = 11, CityName = "Vadodara" },
                new CityList { CityId = 361, StateId = 11, CityName = "Valsad" },
                new CityList { CityId = 362, StateId = 11, CityName = "Vapi" },
                new CityList { CityId = 363, StateId = 11, CityName = "Vastral" },
                new CityList { CityId = 364, StateId = 11, CityName = "Vejalpur" },
                new CityList { CityId = 365, StateId = 11, CityName = "Veraval" },
                new CityList { CityId = 366, StateId = 11, CityName = "Vijalpor" },
                new CityList { CityId = 367, StateId = 11, CityName = "Visnagar" },
                new CityList { CityId = 368, StateId = 11, CityName = "Wadhwan" },
                new CityList { CityId = 369, StateId = 12, CityName = "Ambala" },
                new CityList { CityId = 370, StateId = 12, CityName = "Ambala Cantonment" },
                new CityList { CityId = 371, StateId = 12, CityName = "Ambala Sadar" },
                new CityList { CityId = 372, StateId = 12, CityName = "Bahadurgarh" },
                new CityList { CityId = 373, StateId = 12, CityName = "Bhiwani" },
                new CityList { CityId = 374, StateId = 12, CityName = "Charkhi Dadri" },
                new CityList { CityId = 375, StateId = 12, CityName = "Dabwali" },
                new CityList { CityId = 376, StateId = 12, CityName = "Faridabad" },
                new CityList { CityId = 377, StateId = 12, CityName = "Gohana" },
                new CityList { CityId = 378, StateId = 12, CityName = "Hisar" },
                new CityList { CityId = 379, StateId = 12, CityName = "Jagadhri" },
                new CityList { CityId = 380, StateId = 12, CityName = "Jind" },
                new CityList { CityId = 381, StateId = 12, CityName = "Kaithal" },
                new CityList { CityId = 382, StateId = 12, CityName = "Karnal" },
                new CityList { CityId = 383, StateId = 12, CityName = "Narnaul" },
                new CityList { CityId = 384, StateId = 12, CityName = "Narwana" },
                new CityList { CityId = 385, StateId = 12, CityName = "Palwal" },
                new CityList { CityId = 386, StateId = 12, CityName = "Panchkula" },
                new CityList { CityId = 387, StateId = 12, CityName = "Panipat" },
                new CityList { CityId = 388, StateId = 12, CityName = "Rewari" },
                new CityList { CityId = 389, StateId = 12, CityName = "Rohtak" },
                new CityList { CityId = 390, StateId = 12, CityName = "Sirsa" },
                new CityList { CityId = 391, StateId = 12, CityName = "Sonipat" },
                new CityList { CityId = 392, StateId = 12, CityName = "Thanesar" },
                new CityList { CityId = 393, StateId = 12, CityName = "Tohana" },
                new CityList { CityId = 394, StateId = 12, CityName = "Yamunanagar" },
                new CityList { CityId = 396, StateId = 14, CityName = "Anantnag" },
                new CityList { CityId = 397, StateId = 14, CityName = "Baramula" },
                new CityList { CityId = 398, StateId = 14, CityName = "Bari Brahmana" },
                new CityList { CityId = 399, StateId = 14, CityName = "Jammu" },
                new CityList { CityId = 400, StateId = 14, CityName = "Kathua" },
                new CityList { CityId = 401, StateId = 14, CityName = "Sopur" },
                new CityList { CityId = 402, StateId = 14, CityName = "Srinagar" },
                new CityList { CityId = 403, StateId = 14, CityName = "Udhampur" },
                new CityList { CityId = 404, StateId = 15, CityName = "Adityapur" },
                new CityList { CityId = 405, StateId = 15, CityName = "Bagbahra" },
                new CityList { CityId = 406, StateId = 15, CityName = "Bhuli" },
                new CityList { CityId = 407, StateId = 15, CityName = "Bokaro" },
                new CityList { CityId = 408, StateId = 15, CityName = "Chaibasa" },
                new CityList { CityId = 409, StateId = 15, CityName = "Chas" },
                new CityList { CityId = 410, StateId = 15, CityName = "Daltenganj" },
                new CityList { CityId = 411, StateId = 15, CityName = "Devghar" },
                new CityList { CityId = 412, StateId = 15, CityName = "Dhanbad" },
                new CityList { CityId = 413, StateId = 15, CityName = "Hazaribag" },
                new CityList { CityId = 414, StateId = 15, CityName = "Jamshedpur" },
                new CityList { CityId = 415, StateId = 15, CityName = "Jharia" },
                new CityList { CityId = 416, StateId = 15, CityName = "Jhumri Tilaiya" },
                new CityList { CityId = 417, StateId = 15, CityName = "Jorapokhar" },
                new CityList { CityId = 418, StateId = 15, CityName = "Katras" },
                new CityList { CityId = 419, StateId = 15, CityName = "Lohardaga" },
                new CityList { CityId = 420, StateId = 15, CityName = "Mango" },
                new CityList { CityId = 421, StateId = 15, CityName = "Phusro" },
                new CityList { CityId = 422, StateId = 15, CityName = "Ramgarh" },
                new CityList { CityId = 423, StateId = 15, CityName = "Ranchi" },
                new CityList { CityId = 424, StateId = 15, CityName = "Sahibganj" },
                new CityList { CityId = 425, StateId = 15, CityName = "Saunda" },
                new CityList { CityId = 426, StateId = 15, CityName = "Sindari" },
                new CityList { CityId = 427, StateId = 16, CityName = "Bagalkot" },
                new CityList { CityId = 428, StateId = 16, CityName = "Bangalore" },
                new CityList { CityId = 429, StateId = 16, CityName = "Basavakalyan" },
                new CityList { CityId = 430, StateId = 16, CityName = "Belgaum" },
                new CityList { CityId = 431, StateId = 16, CityName = "Bellary" },
                new CityList { CityId = 432, StateId = 16, CityName = "Bhadravati" },
                new CityList { CityId = 433, StateId = 16, CityName = "Bidar" },
                new CityList { CityId = 434, StateId = 16, CityName = "Bijapur" },
                new CityList { CityId = 435, StateId = 16, CityName = "Bommanahalli" },
                new CityList { CityId = 436, StateId = 16, CityName = "Byatarayanapura" },
                new CityList { CityId = 437, StateId = 16, CityName = "Challakere" },
                new CityList { CityId = 438, StateId = 16, CityName = "Chamrajnagar" },
                new CityList { CityId = 439, StateId = 16, CityName = "Channapatna" },
                new CityList { CityId = 440, StateId = 16, CityName = "Chik Ballapur" },
                new CityList { CityId = 441, StateId = 16, CityName = "Chikmagalur" },
                new CityList { CityId = 442, StateId = 16, CityName = "Chintamani" },
                new CityList { CityId = 443, StateId = 16, CityName = "Chitradurga" },
                new CityList { CityId = 444, StateId = 16, CityName = "Dasarahalli" },
                new CityList { CityId = 445, StateId = 16, CityName = "Davanagere" },
                new CityList { CityId = 446, StateId = 16, CityName = "Dod Ballapur" },
                new CityList { CityId = 447, StateId = 16, CityName = "Gadag" },
                new CityList { CityId = 448, StateId = 16, CityName = "Gangawati" },
                new CityList { CityId = 449, StateId = 16, CityName = "Gokak" },
                new CityList { CityId = 450, StateId = 16, CityName = "Gulbarga" },
                new CityList { CityId = 451, StateId = 16, CityName = "Harihar" },
                new CityList { CityId = 452, StateId = 16, CityName = "Hassan" },
                new CityList { CityId = 453, StateId = 16, CityName = "Haveri" },
                new CityList { CityId = 454, StateId = 16, CityName = "Hiriyur" },
                new CityList { CityId = 455, StateId = 16, CityName = "Hosakote" },
                new CityList { CityId = 456, StateId = 16, CityName = "Hospet" },
                new CityList { CityId = 457, StateId = 16, CityName = "Hubli" },
                new CityList { CityId = 458, StateId = 16, CityName = "Ilkal" },
                new CityList { CityId = 459, StateId = 16, CityName = "Jamkhandi" },
                new CityList { CityId = 460, StateId = 16, CityName = "Kanakapura" },
                new CityList { CityId = 461, StateId = 16, CityName = "Karwar" },
                new CityList { CityId = 462, StateId = 16, CityName = "Kolar" },
                new CityList { CityId = 463, StateId = 16, CityName = "Kollegal" },
                new CityList { CityId = 464, StateId = 16, CityName = "Koppal" },
                new CityList { CityId = 465, StateId = 16, CityName = "Krishnarajapura" },
                new CityList { CityId = 466, StateId = 16, CityName = "Mahadevapura" },
                new CityList { CityId = 467, StateId = 16, CityName = "Maisuru" },
                new CityList { CityId = 468, StateId = 16, CityName = "Mandya" },
                new CityList { CityId = 469, StateId = 16, CityName = "Mangaluru" },
                new CityList { CityId = 470, StateId = 16, CityName = "Nipani" },
                new CityList { CityId = 471, StateId = 16, CityName = "Pattanagere" },
                new CityList { CityId = 472, StateId = 16, CityName = "Puttur" },
                new CityList { CityId = 473, StateId = 16, CityName = "Rabkavi" },
                new CityList { CityId = 474, StateId = 16, CityName = "Raichur" },
                new CityList { CityId = 475, StateId = 16, CityName = "Ramanagaram" },
                new CityList { CityId = 476, StateId = 16, CityName = "Ranibennur" },
                new CityList { CityId = 477, StateId = 16, CityName = "Robertsonpet" },
                new CityList { CityId = 478, StateId = 16, CityName = "Sagar" },
                new CityList { CityId = 479, StateId = 16, CityName = "Shahabad" },
                new CityList { CityId = 480, StateId = 16, CityName = "Shahpur" },
                new CityList { CityId = 481, StateId = 16, CityName = "Shimoga" },
                new CityList { CityId = 482, StateId = 16, CityName = "Shorapur" },
                new CityList { CityId = 483, StateId = 16, CityName = "Sidlaghatta" },
                new CityList { CityId = 484, StateId = 16, CityName = "Sira" },
                new CityList { CityId = 485, StateId = 16, CityName = "Sirsi" },
                new CityList { CityId = 486, StateId = 16, CityName = "Tiptur" },
                new CityList { CityId = 487, StateId = 16, CityName = "Tumkur" },
                new CityList { CityId = 488, StateId = 16, CityName = "Udupi" },
                new CityList { CityId = 489, StateId = 16, CityName = "Ullal" },
                new CityList { CityId = 490, StateId = 16, CityName = "Yadgir" },
                new CityList { CityId = 491, StateId = 16, CityName = "Yelahanka" },
                new CityList { CityId = 492, StateId = 17, CityName = "Alappuzha" },
                new CityList { CityId = 493, StateId = 17, CityName = "Beypur" },
                new CityList { CityId = 494, StateId = 17, CityName = "Cheruvannur" },
                new CityList { CityId = 495, StateId = 17, CityName = "Edakkara" },
                new CityList { CityId = 496, StateId = 17, CityName = "Edathala" },
                new CityList { CityId = 497, StateId = 17, CityName = "Kalamassery" },
                new CityList { CityId = 498, StateId = 17, CityName = "Kannan Devan Hills" },
                new CityList { CityId = 499, StateId = 17, CityName = "Kannangad" },
                new CityList { CityId = 500, StateId = 17, CityName = "Kannur" },
                new CityList { CityId = 501, StateId = 17, CityName = "Kayankulam" },
                new CityList { CityId = 502, StateId = 17, CityName = "Kochi" },
                new CityList { CityId = 503, StateId = 17, CityName = "Kollam" },
                new CityList { CityId = 504, StateId = 17, CityName = "Kottayam" },
                new CityList { CityId = 505, StateId = 17, CityName = "Koyilandi" },
                new CityList { CityId = 506, StateId = 17, CityName = "Kozhikkod" },
                new CityList { CityId = 507, StateId = 17, CityName = "Kunnamkulam" },
                new CityList { CityId = 508, StateId = 17, CityName = "Malappuram" },
                new CityList { CityId = 509, StateId = 17, CityName = "Manjeri" },
                new CityList { CityId = 510, StateId = 17, CityName = "Nedumangad" },
                new CityList { CityId = 511, StateId = 17, CityName = "Neyyattinkara" },
                new CityList { CityId = 512, StateId = 17, CityName = "Palakkad" },
                new CityList { CityId = 513, StateId = 17, CityName = "Pallichal" },
                new CityList { CityId = 514, StateId = 17, CityName = "Payyannur" },
                new CityList { CityId = 515, StateId = 17, CityName = "Ponnani" },
                new CityList { CityId = 516, StateId = 17, CityName = "Talipparamba" },
                new CityList { CityId = 517, StateId = 17, CityName = "Thalassery" },
                new CityList { CityId = 518, StateId = 17, CityName = "Thiruvananthapuram" },
                new CityList { CityId = 519, StateId = 17, CityName = "Thrippunithura" },
                new CityList { CityId = 520, StateId = 17, CityName = "Thrissur" },
                new CityList { CityId = 521, StateId = 17, CityName = "Tirur" },
                new CityList { CityId = 522, StateId = 17, CityName = "Tiruvalla" },
                new CityList { CityId = 523, StateId = 17, CityName = "Vadakara" },
                new CityList { CityId = 524, StateId = 18, CityName = "Ashoknagar" },
                new CityList { CityId = 525, StateId = 18, CityName = "Balaghat" },
                new CityList { CityId = 526, StateId = 18, CityName = "Basoda" },
                new CityList { CityId = 527, StateId = 18, CityName = "Betul" },
                new CityList { CityId = 528, StateId = 18, CityName = "Bhind" },
                new CityList { CityId = 529, StateId = 18, CityName = "Bhopal" },
                new CityList { CityId = 530, StateId = 18, CityName = "BinaEtawa" },
                new CityList { CityId = 531, StateId = 18, CityName = "Burhanpur" },
                new CityList { CityId = 532, StateId = 18, CityName = "Chhatarpur" },
                new CityList { CityId = 533, StateId = 18, CityName = "Chhindwara" },
                new CityList { CityId = 534, StateId = 18, CityName = "Dabra" },
                new CityList { CityId = 535, StateId = 18, CityName = "Damoh" },
                new CityList { CityId = 536, StateId = 18, CityName = "Datia" },
                new CityList { CityId = 537, StateId = 18, CityName = "Dewas" },
                new CityList { CityId = 538, StateId = 18, CityName = "Dhar" },
                new CityList { CityId = 539, StateId = 18, CityName = "Gohad" },
                new CityList { CityId = 540, StateId = 18, CityName = "Guna" },
                new CityList { CityId = 541, StateId = 18, CityName = "Gwalior" },
                new CityList { CityId = 542, StateId = 18, CityName = "Harda" },
                new CityList { CityId = 543, StateId = 18, CityName = "Hoshangabad" },
                new CityList { CityId = 544, StateId = 18, CityName = "Indore" },
                new CityList { CityId = 545, StateId = 18, CityName = "Itarsi" },
                new CityList { CityId = 546, StateId = 18, CityName = "Jabalpur" },
                new CityList { CityId = 547, StateId = 18, CityName = "Jabalpur Cantonment" },
                new CityList { CityId = 548, StateId = 18, CityName = "Jaora" },
                new CityList { CityId = 549, StateId = 18, CityName = "Khandwa" },
                new CityList { CityId = 550, StateId = 18, CityName = "Khargone" },
                new CityList { CityId = 551, StateId = 18, CityName = "Mandidip" },
                new CityList { CityId = 552, StateId = 18, CityName = "Mandsaur" },
                new CityList { CityId = 553, StateId = 18, CityName = "Mau" },
                new CityList { CityId = 554, StateId = 18, CityName = "Morena" },
                new CityList { CityId = 555, StateId = 18, CityName = "Murwara" },
                new CityList { CityId = 556, StateId = 18, CityName = "Nagda" },
                new CityList { CityId = 557, StateId = 18, CityName = "Nimach" },
                new CityList { CityId = 558, StateId = 18, CityName = "Pithampur" },
                new CityList { CityId = 559, StateId = 18, CityName = "Raghogarh" },
                new CityList { CityId = 560, StateId = 18, CityName = "Ratlam" },
                new CityList { CityId = 561, StateId = 18, CityName = "Rewa" },
                new CityList { CityId = 562, StateId = 18, CityName = "Sagar" },
                new CityList { CityId = 563, StateId = 18, CityName = "Sarni" },
                new CityList { CityId = 564, StateId = 18, CityName = "Satna" },
                new CityList { CityId = 565, StateId = 18, CityName = "Sehore" },
                new CityList { CityId = 566, StateId = 18, CityName = "Sendhwa" },
                new CityList { CityId = 567, StateId = 18, CityName = "Seoni" },
                new CityList { CityId = 568, StateId = 18, CityName = "Shahdol" },
                new CityList { CityId = 569, StateId = 18, CityName = "Shajapur" },
                new CityList { CityId = 570, StateId = 18, CityName = "Sheopur" },
                new CityList { CityId = 571, StateId = 18, CityName = "Shivapuri" },
                new CityList { CityId = 572, StateId = 18, CityName = "Sidhi" },
                new CityList { CityId = 573, StateId = 18, CityName = "Singrauli" },
                new CityList { CityId = 574, StateId = 18, CityName = "Tikamgarh" },
                new CityList { CityId = 575, StateId = 18, CityName = "Ujjain" },
                new CityList { CityId = 576, StateId = 18, CityName = "Vidisha" },
                new CityList { CityId = 577, StateId = 19, CityName = "Achalpur" },
                new CityList { CityId = 578, StateId = 19, CityName = "Ahmadnagar" },
                new CityList { CityId = 579, StateId = 19, CityName = "Akola" },
                new CityList { CityId = 580, StateId = 19, CityName = "Akot" },
                new CityList { CityId = 581, StateId = 19, CityName = "Amalner" },
                new CityList { CityId = 582, StateId = 19, CityName = "Ambajogai" },
                new CityList { CityId = 583, StateId = 19, CityName = "Amravati" },
                new CityList { CityId = 584, StateId = 19, CityName = "Anjangaon" },
                new CityList { CityId = 585, StateId = 19, CityName = "Aurangabad" },
                new CityList { CityId = 586, StateId = 19, CityName = "Badlapur" },
                new CityList { CityId = 587, StateId = 19, CityName = "Ballarpur" },
                new CityList { CityId = 588, StateId = 19, CityName = "Baramati" },
                new CityList { CityId = 589, StateId = 19, CityName = "Barsi" },
                new CityList { CityId = 590, StateId = 19, CityName = "Basmat" },
                new CityList { CityId = 591, StateId = 19, CityName = "Bhadravati" },
                new CityList { CityId = 592, StateId = 19, CityName = "Bhandara" },
                new CityList { CityId = 593, StateId = 19, CityName = "Bhiwandi" },
                new CityList { CityId = 594, StateId = 19, CityName = "Bhusawal" },
                new CityList { CityId = 595, StateId = 19, CityName = "Bid" },
                new CityList { CityId = 596, StateId = 19, CityName = "Mumbai" },
                new CityList { CityId = 597, StateId = 19, CityName = "Buldana" },
                new CityList { CityId = 598, StateId = 19, CityName = "Chalisgaon" },
                new CityList { CityId = 599, StateId = 19, CityName = "Chandrapur" },
                new CityList { CityId = 600, StateId = 19, CityName = "Chikhli" },
                new CityList { CityId = 601, StateId = 19, CityName = "Chiplun" },
                new CityList { CityId = 602, StateId = 19, CityName = "Chopda" },
                new CityList { CityId = 603, StateId = 19, CityName = "Dahanu" },
                new CityList { CityId = 604, StateId = 19, CityName = "Deolali" },
                new CityList { CityId = 605, StateId = 19, CityName = "Dhule" },
                new CityList { CityId = 606, StateId = 19, CityName = "Digdoh" },
                new CityList { CityId = 607, StateId = 19, CityName = "Diglur" },
                new CityList { CityId = 608, StateId = 19, CityName = "Gadchiroli" },
                new CityList { CityId = 609, StateId = 19, CityName = "Gondiya" },
                new CityList { CityId = 610, StateId = 19, CityName = "Hinganghat" },
                new CityList { CityId = 611, StateId = 19, CityName = "Hingoli" },
                new CityList { CityId = 612, StateId = 19, CityName = "Ichalkaranji" },
                new CityList { CityId = 613, StateId = 19, CityName = "Jalgaon" },
                new CityList { CityId = 614, StateId = 19, CityName = "Jalna" },
                new CityList { CityId = 615, StateId = 19, CityName = "Kalyan" },
                new CityList { CityId = 616, StateId = 19, CityName = "Kamthi" },
                new CityList { CityId = 617, StateId = 19, CityName = "Karanja" },
                new CityList { CityId = 618, StateId = 19, CityName = "Khadki" },
                new CityList { CityId = 619, StateId = 19, CityName = "Khamgaon" },
                new CityList { CityId = 620, StateId = 19, CityName = "Khopoli" },
                new CityList { CityId = 621, StateId = 19, CityName = "Kolhapur" },
                new CityList { CityId = 622, StateId = 19, CityName = "Kopargaon" },
                new CityList { CityId = 623, StateId = 19, CityName = "Latur" },
                new CityList { CityId = 624, StateId = 19, CityName = "Lonavale" },
                new CityList { CityId = 625, StateId = 19, CityName = "Malegaon" },
                new CityList { CityId = 626, StateId = 19, CityName = "Malkapur" },
                new CityList { CityId = 627, StateId = 19, CityName = "Manmad" },
                new CityList { CityId = 628, StateId = 19, CityName = "Mira Bhayandar" },
                new CityList { CityId = 629, StateId = 19, CityName = "Nagpur" },
                new CityList { CityId = 630, StateId = 19, CityName = "Nalasopara" },
                new CityList { CityId = 631, StateId = 19, CityName = "Nanded" },
                new CityList { CityId = 632, StateId = 19, CityName = "Nandurbar" },
                new CityList { CityId = 633, StateId = 19, CityName = "Nashik" },
                new CityList { CityId = 634, StateId = 19, CityName = "Navghar" },
                new CityList { CityId = 635, StateId = 19, CityName = "Navi Mumbai" },
                new CityList { CityId = 636, StateId = 19, CityName = "Osmanabad" },
                new CityList { CityId = 637, StateId = 19, CityName = "Palghar" },
                new CityList { CityId = 638, StateId = 19, CityName = "Pandharpur" },
                new CityList { CityId = 639, StateId = 19, CityName = "Parbhani" },
                new CityList { CityId = 640, StateId = 19, CityName = "Phaltan" },
                new CityList { CityId = 641, StateId = 19, CityName = "Pimpri" },
                new CityList { CityId = 642, StateId = 19, CityName = "Pune" },
                new CityList { CityId = 643, StateId = 19, CityName = "Pune Cantonment" },
                new CityList { CityId = 644, StateId = 19, CityName = "Pusad" },
                new CityList { CityId = 645, StateId = 19, CityName = "Ratnagiri" },
                new CityList { CityId = 646, StateId = 19, CityName = "SangliMiraj" },
                new CityList { CityId = 647, StateId = 19, CityName = "Satara" },
                new CityList { CityId = 648, StateId = 19, CityName = "Shahada" },
                new CityList { CityId = 649, StateId = 19, CityName = "Shegaon" },
                new CityList { CityId = 650, StateId = 19, CityName = "Shirpur" },
                new CityList { CityId = 651, StateId = 19, CityName = "Sholapur" },
                new CityList { CityId = 652, StateId = 19, CityName = "Shrirampur" },
                new CityList { CityId = 653, StateId = 19, CityName = "Sillod" },
                new CityList { CityId = 654, StateId = 19, CityName = "Thana" },
                new CityList { CityId = 655, StateId = 19, CityName = "Udgir" },
                new CityList { CityId = 656, StateId = 19, CityName = "Ulhasnagar" },
                new CityList { CityId = 657, StateId = 19, CityName = "Uran Islampur" },
                new CityList { CityId = 658, StateId = 19, CityName = "Vasai" },
                new CityList { CityId = 659, StateId = 19, CityName = "Virar" },
                new CityList { CityId = 660, StateId = 19, CityName = "Wadi" },
                new CityList { CityId = 661, StateId = 19, CityName = "Wani" },
                new CityList { CityId = 662, StateId = 19, CityName = "Wardha" },
                new CityList { CityId = 663, StateId = 19, CityName = "Warud" },
                new CityList { CityId = 664, StateId = 19, CityName = "Washim" },
                new CityList { CityId = 665, StateId = 19, CityName = "Yavatmal" },
                new CityList { CityId = 666, StateId = 20, CityName = "Imphal" },
                new CityList { CityId = 667, StateId = 21, CityName = "Shillong" },
                new CityList { CityId = 668, StateId = 21, CityName = "Tura" },
                new CityList { CityId = 669, StateId = 22, CityName = "Aizawl" },
                new CityList { CityId = 670, StateId = 22, CityName = "Lunglei" },
                new CityList { CityId = 671, StateId = 23, CityName = "Dimapur" },
                new CityList { CityId = 672, StateId = 23, CityName = "Kohima" },
                new CityList { CityId = 673, StateId = 23, CityName = "Wokha" },
                new CityList { CityId = 674, StateId = 24, CityName = "Balangir" },
                new CityList { CityId = 675, StateId = 24, CityName = "Baleshwar" },
                new CityList { CityId = 676, StateId = 24, CityName = "Barbil" },
                new CityList { CityId = 677, StateId = 24, CityName = "Bargarh" },
                new CityList { CityId = 678, StateId = 24, CityName = "Baripada" },
                new CityList { CityId = 679, StateId = 24, CityName = "Bhadrak" },
                new CityList { CityId = 680, StateId = 24, CityName = "Bhawanipatna" },
                new CityList { CityId = 681, StateId = 24, CityName = "Bhubaneswar" },
                new CityList { CityId = 682, StateId = 24, CityName = "Brahmapur" },
                new CityList { CityId = 683, StateId = 24, CityName = "Brajrajnagar" },
                new CityList { CityId = 684, StateId = 24, CityName = "Dhenkanal" },
                new CityList { CityId = 685, StateId = 24, CityName = "Jaypur" },
                new CityList { CityId = 686, StateId = 24, CityName = "Jharsuguda" },
                new CityList { CityId = 687, StateId = 24, CityName = "Kataka" },
                new CityList { CityId = 688, StateId = 24, CityName = "Kendujhar" },
                new CityList { CityId = 689, StateId = 24, CityName = "Paradwip" },
                new CityList { CityId = 690, StateId = 24, CityName = "Puri" },
                new CityList { CityId = 691, StateId = 24, CityName = "Raurkela" },
                new CityList { CityId = 692, StateId = 24, CityName = "Raurkela Industrial Township" },
                new CityList { CityId = 693, StateId = 24, CityName = "Rayagada" },
                new CityList { CityId = 694, StateId = 24, CityName = "Sambalpur" },
                new CityList { CityId = 695, StateId = 24, CityName = "Sunabeda" },
                new CityList { CityId = 696, StateId = 25, CityName = "Karaikal" },
                new CityList { CityId = 697, StateId = 25, CityName = "Ozhukarai" },
                new CityList { CityId = 698, StateId = 25, CityName = "Pondicherry" },
                new CityList { CityId = 699, StateId = 26, CityName = "Abohar" },
                new CityList { CityId = 700, StateId = 26, CityName = "Amritsar" },
                new CityList { CityId = 701, StateId = 26, CityName = "Barnala" },
                new CityList { CityId = 702, StateId = 26, CityName = "Batala" },
                new CityList { CityId = 703, StateId = 26, CityName = "Bathinda" },
                new CityList { CityId = 704, StateId = 26, CityName = "Dhuri" },
                new CityList { CityId = 705, StateId = 26, CityName = "Faridkot" },
                new CityList { CityId = 706, StateId = 26, CityName = "Fazilka" },
                new CityList { CityId = 707, StateId = 26, CityName = "Firozpur" },
                new CityList { CityId = 708, StateId = 26, CityName = "Firozpur Cantonment" },
                new CityList { CityId = 709, StateId = 26, CityName = "Gobindgarh" },
                new CityList { CityId = 710, StateId = 26, CityName = "Gurdaspur" },
                new CityList { CityId = 711, StateId = 26, CityName = "Hoshiarpur" },
                new CityList { CityId = 712, StateId = 26, CityName = "Jagraon" },
                new CityList { CityId = 713, StateId = 26, CityName = "Jalandhar" },
                new CityList { CityId = 714, StateId = 26, CityName = "Kapurthala" },
                new CityList { CityId = 715, StateId = 26, CityName = "Khanna" },
                new CityList { CityId = 716, StateId = 26, CityName = "Kot Kapura" },
                new CityList { CityId = 717, StateId = 26, CityName = "Ludhiana" },
                new CityList { CityId = 718, StateId = 26, CityName = "Malaut" },
                new CityList { CityId = 719, StateId = 26, CityName = "Maler Kotla" },
                new CityList { CityId = 720, StateId = 26, CityName = "Mansa" },
                new CityList { CityId = 721, StateId = 26, CityName = "Moga" },
                new CityList { CityId = 722, StateId = 26, CityName = "Mohali" },
                new CityList { CityId = 723, StateId = 26, CityName = "Pathankot" },
                new CityList { CityId = 724, StateId = 26, CityName = "Patiala" },
                new CityList { CityId = 725, StateId = 26, CityName = "Phagwara" },
                new CityList { CityId = 726, StateId = 26, CityName = "Rajpura" },
                new CityList { CityId = 727, StateId = 26, CityName = "Rupnagar" },
                new CityList { CityId = 728, StateId = 26, CityName = "Samana" },
                new CityList { CityId = 729, StateId = 26, CityName = "Sangrur" },
                new CityList { CityId = 730, StateId = 26, CityName = "Sirhind" },
                new CityList { CityId = 731, StateId = 26, CityName = "Sunam" },
                new CityList { CityId = 732, StateId = 26, CityName = "Tarn Taran" },
                new CityList { CityId = 733, StateId = 27, CityName = "Ajmer" },
                new CityList { CityId = 734, StateId = 27, CityName = "Alwar" },
                new CityList { CityId = 735, StateId = 27, CityName = "Balotra" },
                new CityList { CityId = 736, StateId = 27, CityName = "Banswara" },
                new CityList { CityId = 737, StateId = 27, CityName = "Baran" },
                new CityList { CityId = 738, StateId = 27, CityName = "Bari" },
                new CityList { CityId = 739, StateId = 27, CityName = "Barmer" },
                new CityList { CityId = 740, StateId = 27, CityName = "Beawar" },
                new CityList { CityId = 741, StateId = 27, CityName = "Bharatpur" },
                new CityList { CityId = 742, StateId = 27, CityName = "Bhilwara" },
                new CityList { CityId = 743, StateId = 27, CityName = "Bhiwadi" },
                new CityList { CityId = 744, StateId = 27, CityName = "Bikaner" },
                new CityList { CityId = 745, StateId = 27, CityName = "Bundi" },
                new CityList { CityId = 746, StateId = 27, CityName = "Chittaurgarh" },
                new CityList { CityId = 747, StateId = 27, CityName = "Chomun" },
                new CityList { CityId = 748, StateId = 27, CityName = "Churu" },
                new CityList { CityId = 749, StateId = 27, CityName = "Daosa" },
                new CityList { CityId = 750, StateId = 27, CityName = "Dhaulpur" },
                new CityList { CityId = 751, StateId = 27, CityName = "Didwana" },
                new CityList { CityId = 752, StateId = 27, CityName = "Fatehpur" },
                new CityList { CityId = 753, StateId = 27, CityName = "Ganganagar" },
                new CityList { CityId = 754, StateId = 27, CityName = "Gangapur" },
                new CityList { CityId = 755, StateId = 27, CityName = "Hanumangarh" },
                new CityList { CityId = 756, StateId = 27, CityName = "Hindaun" },
                new CityList { CityId = 757, StateId = 27, CityName = "Jaipur" },
                new CityList { CityId = 758, StateId = 27, CityName = "Jaisalmer" },
                new CityList { CityId = 759, StateId = 27, CityName = "Jalor" },
                new CityList { CityId = 760, StateId = 27, CityName = "Jhalawar" },
                new CityList { CityId = 761, StateId = 27, CityName = "Jhunjhunun" },
                new CityList { CityId = 762, StateId = 27, CityName = "Jodhpur" },
                new CityList { CityId = 763, StateId = 27, CityName = "Karauli" },
                new CityList { CityId = 764, StateId = 27, CityName = "Kishangarh" },
                new CityList { CityId = 765, StateId = 27, CityName = "Kota" },
                new CityList { CityId = 766, StateId = 27, CityName = "Kuchaman" },
                new CityList { CityId = 767, StateId = 27, CityName = "Ladnun" },
                new CityList { CityId = 768, StateId = 27, CityName = "Makrana" },
                new CityList { CityId = 769, StateId = 27, CityName = "Nagaur" },
                new CityList { CityId = 770, StateId = 27, CityName = "Nawalgarh" },
                new CityList { CityId = 771, StateId = 27, CityName = "Nimbahera" },
                new CityList { CityId = 772, StateId = 27, CityName = "Nokha" },
                new CityList { CityId = 773, StateId = 27, CityName = "Pali" },
                new CityList { CityId = 774, StateId = 27, CityName = "Rajsamand" },
                new CityList { CityId = 775, StateId = 27, CityName = "Ratangarh" },
                new CityList { CityId = 776, StateId = 27, CityName = "Sardarshahr" },
                new CityList { CityId = 777, StateId = 27, CityName = "Sawai Madhopur" },
                new CityList { CityId = 778, StateId = 27, CityName = "Sikar" },
                new CityList { CityId = 779, StateId = 27, CityName = "Sujangarh" },
                new CityList { CityId = 780, StateId = 27, CityName = "Suratgarh" },
                new CityList { CityId = 781, StateId = 27, CityName = "Tonk" },
                new CityList { CityId = 782, StateId = 27, CityName = "Udaipur" },
                new CityList { CityId = 783, StateId = 28, CityName = "Alandur" },
                new CityList { CityId = 784, StateId = 28, CityName = "Ambattur" },
                new CityList { CityId = 785, StateId = 28, CityName = "Ambur" },
                new CityList { CityId = 786, StateId = 28, CityName = "Arakonam" },
                new CityList { CityId = 787, StateId = 28, CityName = "Arani" },
                new CityList { CityId = 788, StateId = 28, CityName = "Aruppukkottai" },
                new CityList { CityId = 789, StateId = 28, CityName = "Attur" },
                new CityList { CityId = 790, StateId = 28, CityName = "Avadi" },
                new CityList { CityId = 791, StateId = 28, CityName = "Avaniapuram" },
                new CityList { CityId = 792, StateId = 28, CityName = "Bodinayakkanur" },
                new CityList { CityId = 793, StateId = 28, CityName = "Chengalpattu" },
                new CityList { CityId = 794, StateId = 28, CityName = "Dharapuram" },
                new CityList { CityId = 795, StateId = 28, CityName = "Dharmapuri" },
                new CityList { CityId = 796, StateId = 28, CityName = "Dindigul" },
                new CityList { CityId = 797, StateId = 28, CityName = "Erode" },
                new CityList { CityId = 798, StateId = 28, CityName = "Gopichettipalaiyam" },
                new CityList { CityId = 799, StateId = 28, CityName = "Gudalur" },
                new CityList { CityId = 800, StateId = 28, CityName = "Gudiyattam" },
                new CityList { CityId = 801, StateId = 28, CityName = "Hosur" },
                new CityList { CityId = 802, StateId = 28, CityName = "Idappadi" },
                new CityList { CityId = 803, StateId = 28, CityName = "Kadayanallur" },
                new CityList { CityId = 804, StateId = 28, CityName = "Kambam" },
                new CityList { CityId = 805, StateId = 28, CityName = "Kanchipuram" },
                new CityList { CityId = 806, StateId = 28, CityName = "Karur" },
                new CityList { CityId = 807, StateId = 28, CityName = "Kavundampalaiyam" },
                new CityList { CityId = 808, StateId = 28, CityName = "Kovilpatti" },
                new CityList { CityId = 809, StateId = 28, CityName = "Koyampattur" },
                new CityList { CityId = 810, StateId = 28, CityName = "Krishnagiri" },
                new CityList { CityId = 811, StateId = 28, CityName = "Kumarapalaiyam" },
                new CityList { CityId = 812, StateId = 28, CityName = "Kumbakonam" },
                new CityList { CityId = 813, StateId = 28, CityName = "Kuniyamuthur" },
                new CityList { CityId = 814, StateId = 28, CityName = "Kurichi" },
                new CityList { CityId = 815, StateId = 28, CityName = "Madhavaram" },
                new CityList { CityId = 816, StateId = 28, CityName = "Madras" },
                new CityList { CityId = 817, StateId = 28, CityName = "Madurai" },
                new CityList { CityId = 818, StateId = 28, CityName = "Maduravoyal" },
                new CityList { CityId = 819, StateId = 28, CityName = "Mannargudi" },
                new CityList { CityId = 820, StateId = 28, CityName = "Mayiladuthurai" },
                new CityList { CityId = 821, StateId = 28, CityName = "Mettupalayam" },
                new CityList { CityId = 822, StateId = 28, CityName = "Mettur" },
                new CityList { CityId = 823, StateId = 28, CityName = "Nagapattinam" },
                new CityList { CityId = 824, StateId = 28, CityName = "Nagercoil" },
                new CityList { CityId = 825, StateId = 28, CityName = "Namakkal" },
                new CityList { CityId = 826, StateId = 28, CityName = "Nerkunram" },
                new CityList { CityId = 827, StateId = 28, CityName = "Neyveli" },
                new CityList { CityId = 828, StateId = 28, CityName = "Pallavaram" },
                new CityList { CityId = 829, StateId = 28, CityName = "Pammal" },
                new CityList { CityId = 830, StateId = 28, CityName = "Pannuratti" },
                new CityList { CityId = 831, StateId = 28, CityName = "Paramakkudi" },
                new CityList { CityId = 832, StateId = 28, CityName = "Pattukkottai" },
                new CityList { CityId = 833, StateId = 28, CityName = "Pollachi" },
                new CityList { CityId = 834, StateId = 28, CityName = "Pudukkottai" },
                new CityList { CityId = 835, StateId = 28, CityName = "Puliyankudi" },
                new CityList { CityId = 836, StateId = 28, CityName = "Punamalli" },
                new CityList { CityId = 837, StateId = 28, CityName = "Rajapalaiyam" },
                new CityList { CityId = 838, StateId = 28, CityName = "Ramanathapuram" },
                new CityList { CityId = 839, StateId = 28, CityName = "Salem" },
                new CityList { CityId = 840, StateId = 28, CityName = "Sankarankoil" },
                new CityList { CityId = 841, StateId = 28, CityName = "Sivakasi" },
                new CityList { CityId = 842, StateId = 28, CityName = "Srivilliputtur" },
                new CityList { CityId = 843, StateId = 28, CityName = "Tambaram" },
                new CityList { CityId = 844, StateId = 28, CityName = "Tenkasi" },
                new CityList { CityId = 845, StateId = 28, CityName = "Thanjavur" },
                new CityList { CityId = 846, StateId = 28, CityName = "Theni Allinagaram" },
                new CityList { CityId = 847, StateId = 28, CityName = "Thiruthangal" },
                new CityList { CityId = 848, StateId = 28, CityName = "Thiruvarur" },
                new CityList { CityId = 849, StateId = 28, CityName = "Thuthukkudi" },
                new CityList { CityId = 850, StateId = 28, CityName = "Tindivanam" },
                new CityList { CityId = 851, StateId = 28, CityName = "Tiruchchirappalli" },
                new CityList { CityId = 852, StateId = 28, CityName = "Tiruchengode" },
                new CityList { CityId = 853, StateId = 28, CityName = "Tirunelveli" },
                new CityList { CityId = 854, StateId = 28, CityName = "Tirupathur" },
                new CityList { CityId = 855, StateId = 28, CityName = "Tiruppur" },
                new CityList { CityId = 856, StateId = 28, CityName = "Tiruvannamalai" },
                new CityList { CityId = 857, StateId = 28, CityName = "Tiruvottiyur" },
                new CityList { CityId = 858, StateId = 28, CityName = "Udagamandalam" },
                new CityList { CityId = 859, StateId = 28, CityName = "Udumalaipettai" },
                new CityList { CityId = 860, StateId = 28, CityName = "Valparai" },
                new CityList { CityId = 861, StateId = 28, CityName = "Vaniyambadi" },
                new CityList { CityId = 862, StateId = 28, CityName = "Velampalaiyam" },
                new CityList { CityId = 863, StateId = 28, CityName = "Velluru" },
                new CityList { CityId = 864, StateId = 28, CityName = "Viluppuram" },
                new CityList { CityId = 865, StateId = 28, CityName = "Virappanchatram" },
                new CityList { CityId = 866, StateId = 28, CityName = "Virudhachalam" },
                new CityList { CityId = 867, StateId = 28, CityName = "Virudunagar" },
                new CityList { CityId = 868, StateId = 29, CityName = "Agartala" },
                new CityList { CityId = 869, StateId = 29, CityName = "Agartala MCl" },
                new CityList { CityId = 870, StateId = 29, CityName = "Badharghat" },
                new CityList { CityId = 871, StateId = 30, CityName = "Agra" },
                new CityList { CityId = 872, StateId = 30, CityName = "Aligarh" },
                new CityList { CityId = 873, StateId = 30, CityName = "Allahabad" },
                new CityList { CityId = 874, StateId = 30, CityName = "Amroha" },
                new CityList { CityId = 875, StateId = 30, CityName = "Aonla" },
                new CityList { CityId = 876, StateId = 30, CityName = "Auraiya" },
                new CityList { CityId = 877, StateId = 30, CityName = "Ayodhya" },
                new CityList { CityId = 878, StateId = 30, CityName = "Azamgarh" },
                new CityList { CityId = 879, StateId = 30, CityName = "Baheri" },
                new CityList { CityId = 880, StateId = 30, CityName = "Bahraich" },
                new CityList { CityId = 881, StateId = 30, CityName = "Ballia" },
                new CityList { CityId = 882, StateId = 30, CityName = "Balrampur" },
                new CityList { CityId = 883, StateId = 30, CityName = "Banda" },
                new CityList { CityId = 884, StateId = 30, CityName = "Baraut" },
                new CityList { CityId = 885, StateId = 30, CityName = "Bareli" },
                new CityList { CityId = 886, StateId = 30, CityName = "Basti" },
                new CityList { CityId = 887, StateId = 30, CityName = "Behta Hajipur" },
                new CityList { CityId = 888, StateId = 30, CityName = "Bela" },
                new CityList { CityId = 889, StateId = 30, CityName = "Bhadohi" },
                new CityList { CityId = 890, StateId = 30, CityName = "Bijnor" },
                new CityList { CityId = 891, StateId = 30, CityName = "Bisalpur" },
                new CityList { CityId = 892, StateId = 30, CityName = "Biswan" },
                new CityList { CityId = 893, StateId = 30, CityName = "Budaun" },
                new CityList { CityId = 894, StateId = 30, CityName = "Bulandshahr" },
                new CityList { CityId = 895, StateId = 30, CityName = "Chandausi" },
                new CityList { CityId = 896, StateId = 30, CityName = "Chandpur" },
                new CityList { CityId = 897, StateId = 30, CityName = "Chhibramau" },
                new CityList { CityId = 898, StateId = 30, CityName = "Chitrakut Dham" },
                new CityList { CityId = 899, StateId = 30, CityName = "Dadri" },
                new CityList { CityId = 900, StateId = 30, CityName = "Deoband" },
                new CityList { CityId = 901, StateId = 30, CityName = "Deoria" },
                new CityList { CityId = 902, StateId = 30, CityName = "Etah" },
                new CityList { CityId = 903, StateId = 30, CityName = "Etawah" },
                new CityList { CityId = 904, StateId = 30, CityName = "Faizabad" },
                new CityList { CityId = 905, StateId = 30, CityName = "Faridpur" },
                new CityList { CityId = 906, StateId = 30, CityName = "Farrukhabad" },
                new CityList { CityId = 907, StateId = 30, CityName = "Fatehpur" },
                new CityList { CityId = 908, StateId = 30, CityName = "Firozabad" },
                new CityList { CityId = 909, StateId = 30, CityName = "Gajraula" },
                new CityList { CityId = 910, StateId = 30, CityName = "Ganga Ghat" },
                new CityList { CityId = 911, StateId = 30, CityName = "Gangoh" },
                new CityList { CityId = 912, StateId = 30, CityName = "Ghaziabad" },
                new CityList { CityId = 913, StateId = 30, CityName = "Ghazipur" },
                new CityList { CityId = 914, StateId = 30, CityName = "Gola Gokarannath" },
                new CityList { CityId = 915, StateId = 30, CityName = "Gonda" },
                new CityList { CityId = 916, StateId = 30, CityName = "Gorakhpur" },
                new CityList { CityId = 917, StateId = 30, CityName = "Hapur" },
                new CityList { CityId = 918, StateId = 30, CityName = "Hardoi" },
                new CityList { CityId = 919, StateId = 30, CityName = "Hasanpur" },
                new CityList { CityId = 920, StateId = 30, CityName = "Hathras" },
                new CityList { CityId = 921, StateId = 30, CityName = "Jahangirabad" },
                new CityList { CityId = 922, StateId = 30, CityName = "Jalaun" },
                new CityList { CityId = 923, StateId = 30, CityName = "Jaunpur" },
                new CityList { CityId = 924, StateId = 30, CityName = "Jhansi" },
                new CityList { CityId = 925, StateId = 30, CityName = "Kadi" },
                new CityList { CityId = 926, StateId = 30, CityName = "Kairana" },
                new CityList { CityId = 927, StateId = 30, CityName = "Kannauj" },
                new CityList { CityId = 928, StateId = 30, CityName = "Kanpur" },
                new CityList { CityId = 929, StateId = 30, CityName = "Kanpur Cantonment" },
                new CityList { CityId = 930, StateId = 30, CityName = "Kasganj" },
                new CityList { CityId = 931, StateId = 30, CityName = "Khatauli" },
                new CityList { CityId = 932, StateId = 30, CityName = "Khora" },
                new CityList { CityId = 933, StateId = 30, CityName = "Khurja" },
                new CityList { CityId = 934, StateId = 30, CityName = "Kiratpur" },
                new CityList { CityId = 935, StateId = 30, CityName = "Kosi Kalan" },
                new CityList { CityId = 936, StateId = 30, CityName = "Laharpur" },
                new CityList { CityId = 937, StateId = 30, CityName = "Lakhimpur" },
                new CityList { CityId = 938, StateId = 30, CityName = "Lakhnau" },
                new CityList { CityId = 939, StateId = 30, CityName = "Lakhnau Cantonment" },
                new CityList { CityId = 940, StateId = 30, CityName = "Lalitpur" },
                new CityList { CityId = 941, StateId = 30, CityName = "Loni" },
                new CityList { CityId = 942, StateId = 30, CityName = "Mahoba" },
                new CityList { CityId = 943, StateId = 30, CityName = "Mainpuri" },
                new CityList { CityId = 944, StateId = 30, CityName = "Mathura" },
                new CityList { CityId = 945, StateId = 30, CityName = "Mau" },
                new CityList { CityId = 946, StateId = 30, CityName = "Mauranipur" },
                new CityList { CityId = 947, StateId = 30, CityName = "Mawana" },
                new CityList { CityId = 948, StateId = 30, CityName = "Mirat" },
                new CityList { CityId = 949, StateId = 30, CityName = "Mirat Cantonment" },
                new CityList { CityId = 950, StateId = 30, CityName = "Mirzapur" },
                new CityList { CityId = 951, StateId = 30, CityName = "Modinagar" },
                new CityList { CityId = 952, StateId = 30, CityName = "Moradabad" },
                new CityList { CityId = 953, StateId = 30, CityName = "Mubarakpur" },
                new CityList { CityId = 954, StateId = 30, CityName = "Mughal Sarai" },
                new CityList { CityId = 955, StateId = 30, CityName = "Muradnagar" },
                new CityList { CityId = 956, StateId = 30, CityName = "Muzaffarnagar" },
                new CityList { CityId = 957, StateId = 30, CityName = "Nagina" },
                new CityList { CityId = 958, StateId = 30, CityName = "Najibabad" },
                new CityList { CityId = 959, StateId = 30, CityName = "Nawabganj" },
                new CityList { CityId = 960, StateId = 30, CityName = "Noida" },
                new CityList { CityId = 961, StateId = 30, CityName = "Obra" },
                new CityList { CityId = 962, StateId = 30, CityName = "Orai" },
                new CityList { CityId = 963, StateId = 30, CityName = "Pilibhit" },
                new CityList { CityId = 964, StateId = 30, CityName = "Pilkhuwa" },
                new CityList { CityId = 965, StateId = 30, CityName = "Rae Bareli" },
                new CityList { CityId = 966, StateId = 30, CityName = "Ramgarh Nagla Kothi" },
                new CityList { CityId = 967, StateId = 30, CityName = "Rampur" },
                new CityList { CityId = 968, StateId = 30, CityName = "Rath" },
                new CityList { CityId = 969, StateId = 30, CityName = "Renukut" },
                new CityList { CityId = 970, StateId = 30, CityName = "Saharanpur" },
                new CityList { CityId = 971, StateId = 30, CityName = "Sahaswan" },
                new CityList { CityId = 972, StateId = 30, CityName = "Sambhal" },
                new CityList { CityId = 973, StateId = 30, CityName = "Sandila" },
                new CityList { CityId = 974, StateId = 30, CityName = "Shahabad" },
                new CityList { CityId = 975, StateId = 30, CityName = "Shahjahanpur" },
                new CityList { CityId = 976, StateId = 30, CityName = "Shamli" },
                new CityList { CityId = 977, StateId = 30, CityName = "Sherkot" },
                new CityList { CityId = 978, StateId = 30, CityName = "Shikohabad" },
                new CityList { CityId = 979, StateId = 30, CityName = "Sikandarabad" },
                new CityList { CityId = 980, StateId = 30, CityName = "Sitapur" },
                new CityList { CityId = 981, StateId = 30, CityName = "Sukhmalpur Nizamabad" },
                new CityList { CityId = 982, StateId = 30, CityName = "Sultanpur" },
                new CityList { CityId = 983, StateId = 30, CityName = "Tanda" },
                new CityList { CityId = 984, StateId = 30, CityName = "Tilhar" },
                new CityList { CityId = 985, StateId = 30, CityName = "Tundla" },
                new CityList { CityId = 986, StateId = 30, CityName = "Ujhani" },
                new CityList { CityId = 987, StateId = 30, CityName = "Unnao" },
                new CityList { CityId = 988, StateId = 30, CityName = "Varanasi" },
                new CityList { CityId = 989, StateId = 30, CityName = "Vrindavan" },
                new CityList { CityId = 990, StateId = 31, CityName = "Dehra Dun" },
                new CityList { CityId = 991, StateId = 31, CityName = "Dehra Dun Cantonment" },
                new CityList { CityId = 992, StateId = 31, CityName = "Gola Range" },
                new CityList { CityId = 993, StateId = 31, CityName = "Haldwani" },
                new CityList { CityId = 994, StateId = 31, CityName = "Haridwar" },
                new CityList { CityId = 995, StateId = 31, CityName = "Kashipur" },
                new CityList { CityId = 996, StateId = 31, CityName = "Pithoragarh" },
                new CityList { CityId = 997, StateId = 31, CityName = "Rishikesh" },
                new CityList { CityId = 998, StateId = 31, CityName = "Rudrapur" },
                new CityList { CityId = 999, StateId = 31, CityName = "Rurki" },

                new CityList { CityId = 1000, StateId = 13, CityName = "Bilaspur" },
                new CityList { CityId = 1001, StateId = 13, CityName = "Deothsidh" },
                new CityList { CityId = 1002, StateId = 13, CityName = "Ghumarwin" },
                new CityList { CityId = 1003, StateId = 13, CityName = "Naina Devi" },
                new CityList { CityId = 1004, StateId = 13, CityName = "Talai" },

                new CityList { CityId = 1005, StateId = 13, CityName = "Chamba" },
                new CityList { CityId = 1006, StateId = 13, CityName = "Bakloh" },
                new CityList { CityId = 1007, StateId = 13, CityName = "Chowari" },
                new CityList { CityId = 1008, StateId = 13, CityName = "Chuari Khas" },
                new CityList { CityId = 1009, StateId = 13, CityName = "Dalhousie" },
                new CityList { CityId = 1010, StateId = 13, CityName = "Dharwas" },
                new CityList { CityId = 1011, StateId = 13, CityName = "Khajjiar" },
                new CityList { CityId = 1012, StateId = 13, CityName = "Pangi" },
                new CityList { CityId = 1013, StateId = 13, CityName = "Salooni" },

                new CityList { CityId = 1015, StateId = 13, CityName = "Hamirpur" },
                new CityList { CityId = 1016, StateId = 13, CityName = "Bhota" },
                new CityList { CityId = 1017, StateId = 13, CityName = "Nadaun" },
                new CityList { CityId = 1018, StateId = 13, CityName = "Tira Sujanpur" },

                new CityList { CityId = 1020, StateId = 13, CityName = "Kangra" },
                new CityList { CityId = 1021, StateId = 13, CityName = "Baijnath" },
                new CityList { CityId = 1022, StateId = 13, CityName = "Dehra" },
                new CityList { CityId = 1023, StateId = 13, CityName = "Dera Gopipur" },
                new CityList { CityId = 1024, StateId = 13, CityName = "Dharamsala" },
                new CityList { CityId = 1025, StateId = 13, CityName = "Haripur Guler" },
                new CityList { CityId = 1026, StateId = 13, CityName = "Indora" },
                new CityList { CityId = 1027, StateId = 13, CityName = "Jaisinghpur" },
                new CityList { CityId = 1028, StateId = 13, CityName = "Jawalamukhi" },
                new CityList { CityId = 1029, StateId = 13, CityName = "Khaniyara" },
                new CityList { CityId = 1030, StateId = 13, CityName = "Mant Khas" },
                new CityList { CityId = 1031, StateId = 13, CityName = "McLeod Ganj" },
                new CityList { CityId = 1032, StateId = 13, CityName = "Nagarota Surian" },
                new CityList { CityId = 1033, StateId = 13, CityName = "Nagrota Bagwan" },
                new CityList { CityId = 1034, StateId = 13, CityName = "Nurpur" },
                new CityList { CityId = 1035, StateId = 13, CityName = "Palampur" },
                new CityList { CityId = 1036, StateId = 13, CityName = "Rehan" },
                new CityList { CityId = 1037, StateId = 13, CityName = "Shamirpur" },
                new CityList { CityId = 1038, StateId = 13, CityName = "Sidhbari" },

                new CityList { CityId = 1040, StateId = 13, CityName = "Kinnaur" },
                new CityList { CityId = 1041, StateId = 13, CityName = "Kalpa" },
                new CityList { CityId = 1042, StateId = 13, CityName = "Nichar" },
                new CityList { CityId = 1043, StateId = 13, CityName = "Poo" },
                new CityList { CityId = 1044, StateId = 13, CityName = "Reckong Peo" },
                new CityList { CityId = 1045, StateId = 13, CityName = "Sangla" },
                new CityList { CityId = 1046, StateId = 13, CityName = "Wangtu" },

                new CityList { CityId = 1048, StateId = 13, CityName = "Kullu" },
                new CityList { CityId = 1049, StateId = 13, CityName = "Banjar" },
                new CityList { CityId = 1050, StateId = 13, CityName = "Bhuntar" },
                new CityList { CityId = 1051, StateId = 13, CityName = "Manali" },
                new CityList { CityId = 1052, StateId = 13, CityName = "Naggar" },
                new CityList { CityId = 1053, StateId = 13, CityName = "Nirmand" },

                new CityList { CityId = 1055, StateId = 13, CityName = "Lahaul and Spiti" },
                new CityList { CityId = 1056, StateId = 13, CityName = "Darcha" },
                new CityList { CityId = 1057, StateId = 13, CityName = "Jispa" },
                new CityList { CityId = 1058, StateId = 13, CityName = "Kaza" },
                new CityList { CityId = 1059, StateId = 13, CityName = "Keylong" },
                new CityList { CityId = 1060, StateId = 13, CityName = "Sissu" },
                new CityList { CityId = 1061, StateId = 13, CityName = "Tabo" },
                new CityList { CityId = 1062, StateId = 13, CityName = "Zingzingbar" },

                new CityList { CityId = 1065, StateId = 13, CityName = "Mandi" },
                new CityList { CityId = 1066, StateId = 13, CityName = "Bhadarwar" },
                new CityList { CityId = 1067, StateId = 13, CityName = "Jogindernagar" },
                new CityList { CityId = 1068, StateId = 13, CityName = "Karsog" },
                new CityList { CityId = 1069, StateId = 13, CityName = "Rewalsar" },
                new CityList { CityId = 1070, StateId = 13, CityName = "Sandhole" },
                new CityList { CityId = 1071, StateId = 13, CityName = "Sarkaghat" },
                new CityList { CityId = 1072, StateId = 13, CityName = "Sundar Nagar" },

                new CityList { CityId = 1075, StateId = 13, CityName = "Shimla" },
                new CityList { CityId = 1076, StateId = 13, CityName = "Bamta" },
                new CityList { CityId = 1077, StateId = 13, CityName = "Bhattakufer" },
                new CityList { CityId = 1078, StateId = 13, CityName = "Chail" },
                new CityList { CityId = 1079, StateId = 13, CityName = "Chaupal" },
                new CityList { CityId = 1080, StateId = 13, CityName = "Chharabra" },
                new CityList { CityId = 1081, StateId = 13, CityName = "Hatkoti" },
                new CityList { CityId = 1082, StateId = 13, CityName = "Jubbal" },
                new CityList { CityId = 1083, StateId = 13, CityName = "Junga" },
                new CityList { CityId = 1084, StateId = 13, CityName = "Jutogh" },
                new CityList { CityId = 1085, StateId = 13, CityName = "Kasumpati" },
                new CityList { CityId = 1086, StateId = 13, CityName = "Kotkhai" },
                new CityList { CityId = 1087, StateId = 13, CityName = "Kufri" },
                new CityList { CityId = 1088, StateId = 13, CityName = "Mashobra" },
                new CityList { CityId = 1089, StateId = 13, CityName = "Narkanda" },
                new CityList { CityId = 1090, StateId = 13, CityName = "Nawer-Valley" },
                new CityList { CityId = 1091, StateId = 13, CityName = "Nerwa (Chaupal)" },
                new CityList { CityId = 1092, StateId = 13, CityName = "Rampur" },
                new CityList { CityId = 1093, StateId = 13, CityName = "Rohru" },
                new CityList { CityId = 1094, StateId = 13, CityName = "Sanjauli" },
                new CityList { CityId = 1095, StateId = 13, CityName = "Sarahan" },
                new CityList { CityId = 1096, StateId = 13, CityName = "Sawra" },
                new CityList { CityId = 1097, StateId = 13, CityName = "Seoni" },
                new CityList { CityId = 1098, StateId = 13, CityName = "Theog" },

                new CityList { CityId = 1100, StateId = 13, CityName = "Sirmaur" },
                new CityList { CityId = 1101, StateId = 13, CityName = "Dadahu" },
                new CityList { CityId = 1102, StateId = 13, CityName = "Dhaulakuan" },
                new CityList { CityId = 1103, StateId = 13, CityName = "Dhiraina" },
                new CityList { CityId = 1104, StateId = 13, CityName = "Haripurdhar" },
                new CityList { CityId = 1105, StateId = 13, CityName = "Kala Amb" },
                new CityList { CityId = 1106, StateId = 13, CityName = "Nahan" },
                new CityList { CityId = 1107, StateId = 13, CityName = "Paonta Sahib" },
                new CityList { CityId = 1108, StateId = 13, CityName = "Rajban" },
                new CityList { CityId = 1109, StateId = 13, CityName = "Rajgarh" },

                new CityList { CityId = 1111, StateId = 13, CityName = "Solan" },
                new CityList { CityId = 1112, StateId = 13, CityName = "Arki" },
                new CityList { CityId = 1113, StateId = 13, CityName = "Baddi" },
                new CityList { CityId = 1114, StateId = 13, CityName = "Barog" },
                new CityList { CityId = 1115, StateId = 13, CityName = "Dagshai" },
                new CityList { CityId = 1116, StateId = 13, CityName = "Dharampur" },
                new CityList { CityId = 1117, StateId = 13, CityName = "Jubbar" },
                new CityList { CityId = 1118, StateId = 13, CityName = "Kasauli" },
                new CityList { CityId = 1119, StateId = 13, CityName = "Nalagarh" },
                new CityList { CityId = 1120, StateId = 13, CityName = "Parwanoo" },
                new CityList { CityId = 1121, StateId = 13, CityName = "Sabathu" },
                new CityList { CityId = 1122, StateId = 13, CityName = "Waknaghat" },

                new CityList { CityId = 1124, StateId = 13, CityName = "Amb" },
                new CityList { CityId = 1125, StateId = 13, CityName = "Chintpurni" },
                new CityList { CityId = 1126, StateId = 13, CityName = "Daulatpur" },
                new CityList { CityId = 1127, StateId = 13, CityName = "Gagret" },
                new CityList { CityId = 1128, StateId = 13, CityName = "Mehatpur Basdehra" },
                new CityList { CityId = 1129, StateId = 13, CityName = "Santokhgarh" },
                new CityList { CityId = 1130, StateId = 13, CityName = "Una" },

                new CityList { CityId = 1131, StateId = 13, CityName = "Khokhan" },
                new CityList { CityId = 1132, StateId = 13, CityName = "Marhi" }
            };
        }

        public static List<CityList> GetCitiesByStateId(int StateId)
        {
            return AllCities().Where(x => x.StateId == StateId).OrderBy(o => o.CityName).ToList();
        }


        public static string GetCityName(int CityId)
        {
            return AllCities().FirstOrDefault(x => x.CityId == CityId).CityName;
        }
    }

    public class ServerPath
    {
        private const string LocalPath = "";
        private const string serverPath = "http://spectsbazaar.carsake.com/spectsbazaar/";

    public static string Path()
    {
        return serverPath;
    }
    }
}
