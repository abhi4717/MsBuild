using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Project.Models
{
    public class ScenarioPriceData : Massive.DynamicModel
    {
        public ScenarioPriceData()
            : base("PPS")
        {
        }

        public IEnumerable<dynamic> GetScenarioPriceData()
        {
            return this.Query(@"SELECT ScenarioPriceData.Id ScenarioPriceId
                                ,PricingType.Id PricingTypeId
                                ,PricingType.Name PricingTypeName
                                ,Channel.Id ChannelId
                                ,Channel.Name ChannelName
                                ,Product.Id ProductId
                                ,Product.Name ProductName
                                ,ScenarioPriceData.[Values] [Values]
                                FROM ScenarioPriceData
                                JOIN PricingType
                                ON ScenarioPriceData.PricingTypeId = PricingType.Id
                                JOIN Channel
                                ON ScenarioPriceData.ChannelId = Channel.Id
                                JOIN Product
                                ON ScenarioPriceData.ProductId= Product.Id");
        }

    }
}