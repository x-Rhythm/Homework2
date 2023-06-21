public class BirdsCount
{
    List<int> _birdsCount;

    public BirdsCount(List<int> birdsCount){
        _birdsCount = birdsCount;
    }
   public void CountForFirstDays(int number){
    int sum=0;
    for (int i=0; i<number; i++){
      sum+=_birdsCount[i];
  }
  System.Console.WriteLine(sum);
   }
}