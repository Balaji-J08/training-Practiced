package react;

import io.reactivex.Observable;

public class OpeScan 
{

	 static String result="";
	public static void main(String[] args) 
	{
	
		
		String[] letters = {"a", "b","c","d"};
		Observable.fromArray(letters)
		  .scan(new StringBuilder(), StringBuilder::append)
		  .subscribe(total -> result += total.toString());
		System.out.println("Scan operator Results "+result);
		
		
	}
	
}
