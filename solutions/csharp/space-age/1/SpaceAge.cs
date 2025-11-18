public class SpaceAge
{
    private double sec;
    public SpaceAge(int seconds){
        sec=(double)seconds/31557600;
    }
    public double OnEarth()=>sec/1;
    public double OnMercury()=>sec/0.2408467;
    public double OnVenus()=>sec/0.61519726;
    public double OnMars()=>sec/1.8808158;
    public double OnJupiter()=>sec/11.862615;
    public double OnSaturn()=>sec/29.447498;
    public double OnUranus()=>sec/84.016846;
    public double OnNeptune()=>sec/164.79132;
}