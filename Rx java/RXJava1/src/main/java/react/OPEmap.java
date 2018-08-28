package react;

import io.reactivex.Observable;

public class OPEmap 
{
	static String result="";

public static void main(String[] args) 
{

	String[] Alphabits= {"a","b","c","d","e","f","g"};
	Observable<String> obs= Observable.fromArray(Alphabits);
	obs.map(String::toUpperCase).subscribe(
			s -> result += s,
			Throwable::printStackTrace,
			() -> result +=" _completed"
			
			);
	System.out.println("Result of Mapping Operator: "+result);
	
			

	
}
}