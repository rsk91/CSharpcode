class RemoteControlCar
{
    public double d=0;
    public double battery=100;
    public static RemoteControlCar Buy()=> new RemoteControlCar();
    public string DistanceDisplay()=> (battery>0)?$"Driven {d} meters":"Driven 2000 meters";
    public string BatteryDisplay()=> (battery>0)?$"Battery at {battery}%":$"Battery empty";
    public void Drive(){
        d+=20; 
        battery-=1;
    }
}
