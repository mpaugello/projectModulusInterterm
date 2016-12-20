using Android.App;
using Android.OS;
using EaglesNestPrototype.Android.Views;
using EaglesNestPrototype.Core.Data;

namespace EaglesNestPrototype.Android
{
    [Activity(Label = "EaglesNestPrototype.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        static EagleDatabase _database;
        //private static ViewModelLocator _locator;
        //public static ViewModelLocator Locator => _locator ?? (_locator = new ViewModelLocator());

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            StartActivity(typeof(DisplayActivity));
        }

        /**********************************************************************/
        /*                       Get the EaglesDatbase                        */
        /**********************************************************************/
        public static EagleDatabase Database
        {
            get
            {
                /* If the database does not exist, create a new database.     */
                if (_database == null)
                {
                    _database = new EagleDatabase();
                }

                return _database;
            }
        }
    }
}

