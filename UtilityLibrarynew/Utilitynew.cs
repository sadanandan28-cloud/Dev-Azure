using System;
namespace UtilityLibrarynew
{
    public class Utilitynew
    {
    public string GetCurrentDateTime()
            {
                return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }

            public string GetCurrentUTC()
            {
                return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            }

            public string GetCurrentDate()
            {
                return DateTime.Now.ToString("yyyy-MM-dd");
            }

            public string GetCurrentTime()
            {
                return DateTime.Now.ToString("HH:mm:ss");
            }
    }
}
