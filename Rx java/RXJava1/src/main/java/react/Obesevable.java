package react;

import io.reactivex.Observable;

public class Obesevable 
{
	static String result="a";
	public static void main(String[] args) 
	{
	 
		Observable<String> observable = Observable.just("Hello");
		observable.subscribe(s -> result = s);
		System.out.println(result);
		
		  
		//assertTrue(result.equals("Hello"));
	
		
		
	}
}
