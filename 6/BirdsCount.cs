public class BirdsCount
{
    List<int> _birdsCount;

    public BirdsCount(List<int> birdsCount){
        _birdsCount = birdsCount;
    }
    public void BusyDays(){
        int cnt=0;
        foreach (var item in _birdsCount)
        {
            if (item >= 5){
        cnt ++;
            }
        }
        System.Console.WriteLine(cnt);
    }
}