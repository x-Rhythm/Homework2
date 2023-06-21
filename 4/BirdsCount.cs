public class BirdsCount
{
    List<int> _birdsCount;

    public BirdsCount(List<int> birdsCount){
        _birdsCount = birdsCount;
    }
  public void HasDayWithoutBirds(){
    bool birds_1= false;
    foreach (var item in _birdsCount)
    {
      if (item==0){
    System.Console.WriteLine("True");
    break;
      }
      else 
      {
        birds_1=false;
      }
    }
}}