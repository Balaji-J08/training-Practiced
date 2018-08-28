package Com.RockteMQ;

import org.apache.rocketmq.client.producer.DefaultMQProducer;
import org.apache.rocketmq.common.message.Message;
import org.apache.rocketmq.remoting.common.RemotingHelper;

public class One_way 
{
	
	    public static void main(String[] args) throws Exception{
	        
	        DefaultMQProducer producer = new DefaultMQProducer("ExampleProducerGroup");
	        
	        producer.start();
	        for (int i = 0; i < 100; i++) {
	            //Create a message instance, specifying topic, tag and message body.
	            Message msg = new Message("TopicTest" /* Topic */,
	                "TagA" /* Tag */,
	                ("Hello RocketMQ " +
	                    i).getBytes(RemotingHelper.DEFAULT_CHARSET) /* Message body */
	            );
	            //Call send message to deliver message to one of brokers.
	            producer.sendOneway(msg);
	            System.out.println(msg);

	        }
	        //Shut down once the producer instance is not longer in use.
	        producer.shutdown();
	   
	    }
	}
