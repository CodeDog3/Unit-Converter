public class imperial : measurements
{
    public static double convert_dist(double value, iDist imp, mDist met)
    {


        switch (imp, met)
        {
            case (iDist.inch, mDist.meter):
                return ToMeter(value, imp);
            case (iDist.inch, mDist.dekameter):
                return ToDekameter(value, imp);
            case (iDist.inch, mDist.hectometer):
                return ToHectometer(value, imp);
            case (iDist.inch, mDist.kilometer):
                return ToKilometer(value, imp);
            case (iDist.inch, mDist.decimenter):
                return ToDecimeter(value, imp);
            case (iDist.inch, mDist.centimeter):
                return ToCentimeter(value, imp);
            case(iDist.inch, mDist.millimeter):
                return ToMillimeter(value, imp);
            default: return 0;

        }
    }

    public static double convert_weight()
    {
        return 0;
    }

    public static double convert_vol()
    {
        return 0;
    }


    public static double ToMeter(double value, iDist imp)
    {
        switch (imp)
        {
            case (iDist.inch):
                return value / 39.37;
            case (iDist.foot):
                return value / 3.281;
            case (iDist.yard):
                return value / 1.094;
            case (iDist.mile):
                return value / 1609.0;
            default:
            throw new ArgumentException("invalid original unit");
        }

    }

    public static double ToMillimeter(double value, iDist imp)
    {

        switch (imp)
        {
            case iDist.inch:
                value = ToMeter(value, imp);
                return value * 1000;
            case iDist.foot:
                value = ToMeter(value, imp);
                return value * 1000;
            case iDist.yard:
                value = ToMeter(value,imp);
                return value * 1000;
            case iDist.mile:
                value = ToMeter(value, imp);
                return value * 1000;
            default: 
                throw new ArgumentException("invalid original unit");
        }
    }

    public static double ToCentimeter(double value, iDist imp){

        switch (imp)
        {
            case iDist.inch:
                value = ToMeter(value, imp);
                return value * 100;
            case iDist.foot:
                value = ToMeter(value, imp);
                return value * 100;
            case iDist.yard:
                value = ToMeter(value,imp);
                return value * 100;
            case iDist.mile:
                value = ToMeter(value, imp);
                return value * 100;
            default: 
                throw new ArgumentException("invalid original unit");
        }
    }
    public static double ToDecimeter(double value, iDist imp){

        switch (imp)
        {
            case iDist.inch:
                value = ToMeter(value, imp);
                return value * 10;
            case iDist.foot:
                value = ToMeter(value, imp);
                return value * 10;
            case iDist.yard:
                value = ToMeter(value,imp);
                return value * 10;
            case iDist.mile:
                value = ToMeter(value, imp);
                return value * 10;
            default: 
                throw new ArgumentException("invalid original unit");
        }
    }

    public static double ToDekameter(double value, iDist imp){

        switch (imp)
        {
            case iDist.inch:
                value = ToMeter(value, imp);
                return value / 10;
            case iDist.foot:
                value = ToMeter(value, imp);
                return value / 10;
            case iDist.yard:
                value = ToMeter(value,imp);
                return value / 10;
            case iDist.mile:
                value = ToMeter(value, imp);
                return value / 10;
            default: 
                throw new ArgumentException("invalid original unit");
        }
    }

    public static double ToHectometer(double value, iDist imp){

        switch (imp)
        {
            case iDist.inch:
                value = ToMeter(value, imp);
                return value / 100;
            case iDist.foot:
                value = ToMeter(value, imp);
                return value / 100;
            case iDist.yard:
                value = ToMeter(value,imp);
                return value / 100;
            case iDist.mile:
                value = ToMeter(value, imp);
                return value / 100;
            default: 
                throw new ArgumentException("invalid original unit");
        }
    }

    public static double ToKilometer(double value, iDist imp){

        switch (imp)
        {
            case iDist.inch:
                value = ToMeter(value, imp);
                return value / 1000;
            case iDist.foot:
                value = ToMeter(value, imp);
                return value / 1000;
            case iDist.yard:
                value = ToMeter(value,imp);
                return value / 1000;
            case iDist.mile:
                value = ToMeter(value, imp);
                return value / 1000;
            default: 
                throw new ArgumentException("invalid original unit");
        }
    }
}

