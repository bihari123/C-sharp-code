class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
public int ExpectedMinutesInOven(){
    return 40;
  }

  public int RemainingMinutesInOven(int x){
    if (x >40){
      return 0;
    }
    return 40-x;
  }

  public int PreparationTimeInMinutes(int num_of_layer){
    return 2 * num_of_layer;
  }

  public int ElapsedTimeInMinutes(int num_of_layer, int time_elapsed){
    return (2*num_of_layer )+ (time_elapsed);
  }
}
