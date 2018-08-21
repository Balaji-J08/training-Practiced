package JavaRestfull.First;
import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;

@Path("/div")
public class First{

	
	@GET()
	@Path("/msg")
	@Produces(MediaType.TEXT_PLAIN)
public String SayHi()
{
	return "Hiiiiiii everyone..Lets start the Work!!!";
}
}
