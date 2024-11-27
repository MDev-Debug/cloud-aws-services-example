using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

var client = new AmazonSQSClient(RegionEndpoint.USEast1);
var request = new ReceiveMessageRequest("https://sqs.us-east-1.amazonaws.com/207567769079/teste");
var response = await client.ReceiveMessageAsync(request);


var x = 10;