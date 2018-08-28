package react;

import io.reactivex.Observable;

public class OpeGrpby
{

	static int EVEN[];
	static int ODD[];
	static int number; 
	
	public static void main(String[] args) 
	{
	
		int numbers[]= {20,21,22,23,24,25,26,27,28,29,30};
		
		Observable.fromArray(numbers)
		  .groupBy(i -> 0 == (i % 2) ? "EVEN" : "ODD")
		  .subscribe(group ->
		    group.subscribe((number) -> {
		        if (group.getKey().toString().equals("EVEN")) 
		        {
		           EVEN[0] += number;
		        } else {
		            ODD[0] += number;
		        }
		    })
		  );
		
	}
	
	
}
