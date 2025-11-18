class RemoteControlCar
{
    public double d=0;
    public double battery=100;
    public static RemoteControlCar Buy()=> new RemoteControlCar();
    public string DistanceDisplay()=> $"Driven {d} meters";
    public string BatteryDisplay()=> (battery>0)?$"Battery at {battery}%":$"Battery empty";
    public void Drive(){
        if(battery>0)
            d+=20;
            battery-=1;
    }
}
