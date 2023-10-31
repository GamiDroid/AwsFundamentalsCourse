
using Amazon.SecretsManager;
using Amazon.SecretsManager.Model;

var secretsManagerClient = new AmazonSecretsManagerClient();

var request = new GetSecretValueRequest
{
    SecretId = "ApiKey",
};

var response = await secretsManagerClient.GetSecretValueAsync(request);

Console.WriteLine(response.SecretString);