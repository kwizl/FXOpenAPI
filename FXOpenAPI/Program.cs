// See https://aka.ms/new-console-template for more information
using FXOpenAPI.Account_Information;
using FXOpenAPI.Logic.StaticStrings;

Console.WriteLine("Program Starting............................!");

string id = Credentials.ID;
string key = Credentials.Key;
string secret = Credentials.Secret;
string baseUrl = Url.BaseUrl;

AccountAPI account = new(baseUrl, id, key, secret);
await account.GetAccountInformation();