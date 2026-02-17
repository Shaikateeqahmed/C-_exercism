static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed >=0 && speed<1){
            return 0;
        }else if(speed >=1 && speed<=4){
            return 1;
        }else if(speed >=5 && speed <= 8){
            return 0.90;
        }else if(speed >= 9 && speed <10){
            return 0.80;
        }else{
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return SuccessRate(speed)*speed*221;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double result = ProductionRatePerHour(speed) / 60;
       return (Int32)result;
    }
}
