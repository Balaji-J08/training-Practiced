package com.app;

import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;

@Path("/msg")
public class first {
	@GET
	@Produces("text/plain")
	public String Hii()
	{
		return "Hii Everyone";
	}

}
