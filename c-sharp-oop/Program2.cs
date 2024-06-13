namespace c_sharp_fundamentals;

class Car : Vehicle
{
    public string model;
    public string color;
    public int year;

    public Car(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }
}