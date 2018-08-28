package react;

import io.reactivex.Observable;

public class observble
{
  static String result="";
	
	public static void main(String[] args) 
	{
	
		String[] letters = {"a", "b", "c", "d", "e", "f", "g"};
		Observable<String> observable = Observable.fromArray(letters);
		
		observable.map(String::toUpperCase).subscribe(
		  i -> result += i,  //OnNext
		  Throwable::printStackTrace, //OnError
		  () -> result += "_Completed" //OnCompleted
		);
		
		System.out.println(result); 
		//assertTrue(result.equals("abcdefg_Completed"));
	
	}
}
