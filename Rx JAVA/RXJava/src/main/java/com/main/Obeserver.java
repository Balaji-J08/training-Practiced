package com.main;

import io.reactivex.Observer;
import io.reactivex.disposables.Disposable;

public class Obeserver implements Observer<String>
{


	public void onNext(String t) {
		System.out.println("Contents is as Follows: "+t);
		
	}

	public void onError(Throwable e) {
		System.out.println("errrorr..");
		
	}

	public void onComplete() {
		System.out.println("completed");
		
	}

	public void onSubscribe(Disposable d) {
		System.out.println("now ur Subscribed ");
	}

}
