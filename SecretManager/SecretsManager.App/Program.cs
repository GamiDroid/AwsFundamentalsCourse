
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;

var secretsManagerClient = new AmazonSecretsManagerClient();

var listVersionsRequest = new ListSecretVersionIdsRequest
{
    SecretId = "ApiKey",
    IncludeDeprecated = true,
};

var listVersionsResponse = await secretsManagerClient.ListSecretVersionIdsAsync(listVersionsRequest);

var request = new GetSecretValueRequest
{
    SecretId = "ApiKey",
    //VersionStage = "AWSCURRENT",
    //VersionStage = "AWSPREVIOUS",
};

var response = await secretsManagerClient.GetSecretValueAsync(request);

Console.WriteLine(response.SecretString);

var describeRequest = new DescribeSecretRequest
{
    SecretId = "ApiKey"
};

var describeResponse = await secretsManagerClient.DescribeSecretAsync(describeRequest);

Console.WriteLine();