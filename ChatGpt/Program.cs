﻿// See https://aka.ms/new-console-template for more information

using System.Text;
using ChatGPT.Net;
using ChatGPT.Net.DTO;

Console.WriteLine("Hello, World!");

var chatGpt = new ChatGpt();

await chatGpt.WaitForReady();

var chatGptClient = await  chatGpt.CreateClient(new ChatGptClientConfig
{
    SessionToken = "eyJhbGciOiJkaXIiLCJlbmMiOiJBMjU2R0NNIn0..WF0fK5MZ_sQfR5iK.f5g9gric0BQkWvkrsGrXKo2SA-s7P3nwvGJ9C9hIQlmz62jtX7B2dL2140Bx_jvftd7qEmvdp2hM21CpZUbjSdKrTuBDHph9xoAGlkLV2Zkno40GzN6jEfLsUlepu7kXot0oeJHcyELpU2_2wzCsqBURQCvZumJ6-akR9mbCiJStJZoQ5S1oMpDDZRMBkIjO-zx70HP92FlQLPiDnNSFqcuWmWnVZNzwCZb54cRMVu9SAoMnSL-WOMUzHGAT9JopqVoaxLJ3DTUiPNfwajPXY39YB_H2O3Z1uo2JaeNQd9Ne3GyutfVrwS2CEuwKqxW5Mm-crSGnnpflzPrqeIYgX2-QC4kYBgjj9CkfQwkhonjnEY7FN8Hy_7UIEJelLTmRYl4gcJv5rD3IdKFfVItIyXO-mpJM6iVO7yHaNmyWwlk2RMx0Q46vw1xZCwfz0BLa0HdwKkFg5o2_qgkSpYfoZylcUyurgtRSbaubzJs7BtRe6UXrDhlNEwlQYA_Bi8Kt8bFC3EcFiMjW7PNm7SvKZ3PK2A_Dx2Cwx98NZ2zWK--vN1a2-aU51h2qp-9k9-qfoqBnb3lLgbvuQTLrHUkNdwIwy6urpqDMcsloq02ff2rpfQoQNzpjv0tsgDYLnSMGzz35f2Bdx7EGdHQLD7eC9K5dUciGxQRDPKwHVqgwkR1NJgZDCHYdRTm4ovN_CySJ8KVaQzBGh1bOMGzY6DVdTWDPHMrcTm4ffuSKgyzN09wMlIxCLH2-fJomZvSmj6nuX8SHbtSpDueoUV4q0t8kZGRfgXz1XEJRl9y0CJrI7k4DS2cYMEPWF8toJyDFXvv4J2WSqB3wSvrPjn-geU8Dd9-o__wMhX02dQ_0kLFm6S_2SXx-SGkk-EWBAzQ87P9k3L5y2eRVout1GTaIBlR4fz_mkIyjy2WYpywi5edCNFDMEVv4ienkfT_kJeABfCWFGpUUsaT8bAH2ShZGtyGha7KQVT5uPX6t8NLxnlJpkqMGzz3ARbKmSUGGGZwhSAr8yjmX-bHZ28a5Wl0l6lzvf_3viVXC5UYOqY8cHrAKM2LDCAwIcSFaLYPC6PFPBrRCORNLFoXhFMgru5GswLWHWqr_fu90EgnSb5jakgbltRX4ufBW3lT0klMVfbv6usbhKmm6vC3mzbpZd-pGdPsGPieyGYFp5-08xlkyP_PZ1Tv6sfwTXqqSVaTtp-FqqqIcT-w7BeOjWU9FDz4iarS_Z2htA0NBbKiItpk62NLA0iS-tcqfEASVpqqBIWcbQHe2Gt9X_Iw-7qrPw94-Gh1Qu0AtC9tC3cB1lcCV5ioUzp11TomSrTQX-GUwBJ9lzyAc8gnj7Ai2kuT97qeLScvrkp6Wm9Yv335sPHdOWfNoyQuRMR7UQBMqLHZiN542ziRJDonubKMSVmKdNDo49X8ttEgo1eqR12TGR8NXz4IsqpMutodsaG4pTlLVrubp7zayJmeaVPwhdsOCClGWokPWvep2RmZCxOT1FZkvqo4_8zxadzlYrOH0uHNwYp2TYyvdzGA0eTVhw4AowbQmnq430l49O5BEFqZOEIHhPXdMIRIJAwFbHxRqatxK1dqrmZYLy7Bm5VFAl4ZyHiLr9X7tsMG8tYTDGVF0OFWGUC8ml1dvgDh71KC_Ce9gufPg2xJk4qnYSetx2rFnyAw6IxMitDi2iiL0UNigAluliCjMQDiypHMT9xNGTBrtQq6YPHAZWBt_8egQCpYGsvu4n9DCax8nMZD_ijs5_p2bzc7RUpBZ22IYrfAgUR4lwtHgtG4YkKs_jhATQlyLI1oPu4HJsWRHQW-d8PmbxLnJ3HJEJiQobTY-PJF1ObMuwuMNsWN2W7NMuixGfJfwFUrUJuvljEno652aozOwQPcWwPEACNVdYvRNYRMISkZxtXjnOc9r8yeQIJeyCwWwhUx-xCBwlubCCmjCgtHTvDjCjsD5iL5WMRh0zlV8WWeyy7eHMqmy1-8GzMY9Fj1Ru2uwKOctyvGp4KPqlu1d9huq2NgcP7TAgl7X0Yt53ziXxnBbT5WMAnuAtswW5aYOoUHr7T8DDqJWmSozucDMVTWun7x6GueZzotZKFmv7gKHHP2plNOZpsAGS8hVpJ-w1H9XCh4Vz-ssDUAXdUYQewtpSOlMXKfUJVz2HJDKmu4b541uIih4beTVRzTBqHqJKd0vqsxWsrBjHxTMEfuHEtx9batKk89juwiBOCPIQYbKhDCqOFHPIdsm-vXcohN3Zhu5svC1r5TCl-fg75_ZsKX_w8cu7eGvIfcrI6N8nCLrCtVx2-kv0LvGf1pmG_SBL2B5X87_jQ8unoXGAmVtaLpqw-KdyPynOx5ohPMV8lILMyviZyNR5feKDJHTYs5G3uXJHl-kHApF1w9kprTBhy463D4AuXyNUhEAeWA8fljFo89Qh2njXTUKqEqO6q6cEbiDhwJ-TZrPKzp3aSlcSxw9dh7JsKJEpuXaVpU9gU8vuLZ3rpC3BuGtQXNiKNVIik8I9UbX56mR2bfPBhMQtfwFf1Qfg4LKsqgPieAREo3gX6zuA3L8btIG9d--1PujbAP_37D22zlUePmUaPf9IVID8sdhW7p5YalUIaFtU7n5Am-cJv5mq_Zv17J9CUCdzGhTnltSDLysMp2mWn5r2cFoREM9o27IbUsZUmswFWLMxoQF75bY_4c.ii8Jw19Q41z3jj2G5pq4Vw"
});

// var text = Console.ReadLine() ?? "1+1等於幾";

var response = await chatGptClient.Ask("1+1等於幾");

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
Console.WriteLine(response);
Console.WriteLine("輸入問題:");