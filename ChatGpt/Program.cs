// See https://aka.ms/new-console-template for more information

using System.Text;
using ChatGPT.Net;
using ChatGPT.Net.DTO;

Console.WriteLine("Hello, World!");

var chatGpt = new ChatGpt();

await chatGpt.WaitForReady();

var chatGptClient = await  chatGpt.CreateClient(new ChatGptClientConfig
{
    SessionToken = ""
});

// var text = Console.ReadLine() ?? "1+1等於幾";

var response = await chatGptClient.Ask("text");

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
Console.WriteLine(response);
Console.WriteLine("輸入問題:");
