using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockForThePeople.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForThePeople.Data.Configurations
{
    internal class AssetConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            DateTime useDate = new DateTime(2025, 01, 01);
            builder.HasData(
                new Asset
                {
                    Id = Guid.Parse("0c6188c9-399d-491e-a234-64806a82e0f6"),
                    CreatedAt = useDate,
                    ModifiedAt = useDate,
                    Ticker = "TDIV.AS",
                    Name = "Morningstar Developed Markets Dividend Leaders",
                    Symbol = "TDIV",
                    Type = "ETF",
                    Exchange = "AS",
                    Currency = "EUR"

                },
                new Asset
                {
                    Id = Guid.Parse("6886bc8d-0824-4984-95f6-8c6d068b97eb"),
                    CreatedAt = useDate,
                    ModifiedAt = useDate,
                    Ticker = "SHELL.AS",
                    Name = "Royal Dutch Shell",
                    Symbol = "SHELL",
                    Type = "Common stock",
                    Exchange = "AS",
                    Currency = "EUR"
                },
                new Asset
                {
                    Id = Guid.Parse("a77cce6f-c0e7-4959-8ede-44cf1e193a5a"),
                    CreatedAt = useDate,
                    ModifiedAt = useDate,
                    Ticker = "ALFEN.AS",
                    Name = "Alfen laadpalen",
                    Symbol = "ALFEN",
                    Exchange = "AS",
                    Currency = "EUR"
                },
                new Asset
                {
                    Id = Guid.Parse("95a75464-45a2-4277-9c17-e64813fbb033"),
                    CreatedAt = useDate,
                    ModifiedAt = useDate,
                    Ticker = "INGA.AS",
                    Name = "ING Bank",
                    Symbol = "INGA",
                    Exchange = "AS",
                    Currency = "EUR"
                },
                new Asset
                {
                    Id = Guid.Parse("4e105535-db12-4395-a9f6-342d3fd477b1"),
                    CreatedAt = useDate,
                    ModifiedAt = useDate,
                    Ticker = "AD.AS",
                    Name = "Ahold",
                    Symbol = "AD",
                    Exchange = "AS",
                    Currency = "EUR"
                },
                new Asset
                {
                    Id = Guid.Parse("24da7af9-e7f7-4cbb-b5a7-77127a3c888c"),
                    CreatedAt = useDate,
                    ModifiedAt = useDate,
                    Ticker = "KPN.AS",
                    Name = "KPN",
                    Symbol = "KPN",
                    Exchange = "AS",
                    Currency = "EUR"
                },
                new Asset
                {
                    Id = Guid.Parse("363d100a-f412-4709-9c44-e60b7617c64e"),
                    CreatedAt = useDate,
                    ModifiedAt = useDate,
                    Ticker = "PHARM.AS",
                    Name = "Pharming",
                    Symbol = "PHARM",
                    Exchange = "AS",
                    Currency = "EUR"
                },
                new Asset
                {
                    Id = Guid.Parse("2b4e7c35-069f-46e3-985f-ba02f89a494b"),
                    CreatedAt = useDate,
                    ModifiedAt=useDate,
                    Ticker="1BR1.F",
                    Name="Unibail Rodamco",
                    Symbol="1BR1",
                    Exchange="F",
                    Currency="EUR"
                },
                new Asset
                {
                    Id=Guid.Parse("53290d2d-d91b-46a7-8917-33f439a0a494"),
                    CreatedAt=useDate,
                    ModifiedAt=useDate,
                    Ticker="UNA.AS",
                    Name="Unilever",
                    Symbol="UNA",
                    Exchange="AS",
                    Currency="EUR"
                },
                new Asset
                {
                    Id=Guid.Parse("58d92555-d2d4-483c-975e-87190aba62ec"),
                    CreatedAt=useDate,
                    ModifiedAt=useDate,
                    Ticker="TDT.AS",
                    Name="VanEck AEX ETF",
                    Symbol="TDT",
                    Exchange="AS",
                    Currency="EUR",
                    Type="ETF"
                },
                new Asset
                {
                    Id=Guid.Parse("1772edb4-5159-44e7-91ca-0d5b56122770"),
                    CreatedAt=useDate,
                    ModifiedAt=useDate,
                    Ticker="ASML.AS",
                    Name="ASML",
                    Symbol="ASML",
                    Exchange="AS",
                    Currency="EUR"
                },
                new Asset
                {
                    Id=Guid.Parse("13e35aab-c362-40b2-91d3-300c41508fed"),
                    CreatedAt=useDate,
                    ModifiedAt=useDate,
                    Ticker="NN.AS",
                    Name="Nationale Nederlanden",
                    Symbol="NN",
                    Exchange="AS",
                    Currency="EUR"
                },
                new Asset
                {
                    Id=Guid.Parse("6e89c090-a1c4-46db-ae4a-e561b497e90d"),
                    CreatedAt=useDate,
                    ModifiedAt=useDate,
                    Ticker="BESI.AS",
                    Name= "BE Semiconductor Industries NV",
                    Symbol="BESI",
                    Exchange="AS",
                    Currency="EUR"
                },
                new Asset
                {
                    Id=Guid.Parse("0d32dbbf-39f1-4e2a-8c0f-f74129985dfb"),
                    CreatedAt=useDate,
                    ModifiedAt=useDate,
                    Ticker="ABN.AS",
                    Name="ABN",
                    Symbol="ABN",
                    Exchange="AS",
                    Currency="EUR"
                },
                new Asset
                {
                    Id=Guid.Parse("8b02aae5-8a1a-483a-af0f-e89c43df22b1"),
                    CreatedAt=useDate,
                    ModifiedAt=useDate,
                    Ticker="DSMFF.US",
                    Name="DSM",
                    Symbol="DSMFF",
                    Exchange="US",
                    Currency="DOLLAR"
                }

                );

        }
    }
}
