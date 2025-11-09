class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed; //construcor
    private int battery=100;
    private int distanceDiven=0;
    private int batteryDrain;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed=speed;
        this.batteryDrain=batteryDrain;
    }
    public bool BatteryDrained() => (batteryDrain>battery);
    public int DistanceDriven()=> distanceDiven;
    public void Drive(){
        if(!BatteryDrained())
        {
            distanceDiven+=speed; 
            battery-=batteryDrain;
        }
    }
    public static RemoteControlCar Nitro()=> new RemoteControlCar(50, 4);
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;
    public RaceTrack(int distance)
    {
        this.distance=distance;
    }
    public bool TryFinishTrack(RemoteControlCar car){
        while(!car.BatteryDrained())
        {
            car.Drive();
            if(car.DistanceDriven()>=distance)
                return true;
        }
        return false;
    }
}
