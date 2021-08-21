namespace DiPatternSample.Console
{
    public class DALFactory
    {
        public static DAL GetDAL()
        {
            return (new DAL());
        }
    }
}