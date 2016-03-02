public class MultiIndex
{
    private object[][] _index;
    private string[] _names;
    
    public MultiIndex(string names, object[] index)
    {
        this._levels = new object[1];
        this._levels[0] = index;
        
        this._names = new string[1];
        this._names[0] = names
    }
    
    public static MultiIndex FromTuples(string[] names, object[][] indexTuples)
    {
        MultiIndex instance = new MultiIndex();
        
        // blah blah blah
        
        return instance;
    }
}