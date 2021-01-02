using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeApiWrapperTests
{
    public static class   ApiJsonResponces
    {
        public static string GetVideoCommentsFirstPage { get; set; } = @"{
  ""kind"": ""youtube#commentThreadListResponse"",
  ""etag"": ""6Ckrza1rruvvCbLjW5Vljp_JqqE"",
  ""nextPageToken"": ""QURTSl9pMFE0YmF6TzRaR1JIQmtKRndNcGRPekJ1TW5oVE5SLXk1S0wxNE4yZkt1UGctR1BlR016NUYyVFQtczBLQnB1V1VHYzNGN3g1VTZKaG9OdHVqeVVOUm1JWHZhYWc="",
  ""pageInfo"": {
    ""totalResults"": 100,
    ""resultsPerPage"": 100
  },
  ""items"": [
    {
      ""kind"": ""youtube#commentThread"",
      ""etag"": ""y9OT4W9WVz6DRNgMYv0F80FU-dM"",
      ""id"": ""Ugz5Y-pZZp56-1q3q054AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
          ""kind"": ""youtube#comment"",
          ""etag"": ""ZUoqPluaiKiiTfVcoGCSe8uEgnM"",
          ""id"": ""Ugz5Y-pZZp56-1q3q054AaABAg"",
          ""snippet"": {
            ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=00h00m00s\""\u003e00:00:00\u003c/a\u003e Сила с Вами\u003cbr /\u003e\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=00h01m00s\""\u003e00:01:00\u003c/a\u003e Страшно независимая женщина \r\u003cbr /\u003e\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=00h10m18s\""\u003e00:10:18\u003c/a\u003e Дети Стивена Кинга\r\u003cbr /\u003e\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=00h13m15s\""\u003e00:13:15\u003c/a\u003e Между пропастью и жаром\r\u003cbr /\u003e\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=00h16m07s\""\u003e00:16:07\u003c/a\u003e Кровожадный Пацифист\r\u003cbr /\u003e\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=00h21m58s\""\u003e00:21:58\u003c/a\u003e Старые христиане людоеды \r\u003cbr /\u003e\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=00h27m14s\""\u003e00:27:14\u003c/a\u003e Пищевой Кайф \r\u003cbr /\u003e\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=00h30m34s\""\u003e00:30:34\u003c/a\u003e Детройт – город моторов \r\u003cbr /\u003e\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=00h37m23s\""\u003e00:37:23\u003c/a\u003e Проверка на честность \r\u003cbr /\u003e\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=00h42m00s\""\u003e00:42:00\u003c/a\u003e Все возможно\u003cbr /\u003e\u003cbr /\u003eОСНОВАНИЕ.LIFE  (ТУТ ТЕКСТА):\r\u003cbr /\u003e\u003ca href=\""https://t.me/osnovanie_life\""\u003ehttps://t.me/osnovanie_life\u003c/a\u003e"",
            ""textOriginal"": ""00:00:00 Сила с Вами\n00:01:00 Страшно независимая женщина \r\n00:10:18 Дети Стивена Кинга\r\n00:13:15 Между пропастью и жаром\r\n00:16:07 Кровожадный Пацифист\r\n00:21:58 Старые христиане людоеды \r\n00:27:14 Пищевой Кайф \r\n00:30:34 Детройт – город моторов \r\n00:37:23 Проверка на честность \r\n00:42:00 Все возможно\n\nОСНОВАНИЕ.LIFE  (ТУТ ТЕКСТА):\r\nhttps://t.me/osnovanie_life"",
            ""authorDisplayName"": ""ОСНОВАНИЕ"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniuPEfCtW4Wbr2yt1PBZ451i2L4SIVjpOyM0IsS=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCXOzPAwI8ChKpGjRXE4E7ew"",
            ""authorChannelId"": {
              ""value"": ""UCXOzPAwI8ChKpGjRXE4E7ew""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 25,
            ""publishedAt"": ""2020-12-29T20:52:31Z"",
            ""updatedAt"": ""2020-12-29T20:52:51Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 2,
        ""isPublic"": true
      }
    },
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""QUTG5z1w1kXSqzWs5q7QIAHcppU"",
      ""id"": ""UgxUMw-YatbCA_asiu94AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""270S1ynX7MMv21NncRHcPqFO7Yg"",
          ""id"": ""UgxUMw-YatbCA_asiu94AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Сила в хату)"",
            ""textOriginal"": ""Сила в хату)"",
            ""authorDisplayName"": ""Роман Воробьев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniiP1_xGlNtohkApmDwixyFHvnyat3OdT_FIA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCFrHzdp2WpKEiV--MqvNFmQ"",
            ""authorChannelId"": {
                    ""value"": ""UCFrHzdp2WpKEiV--MqvNFmQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T14:59:48Z"",
            ""updatedAt"": ""2021-01-02T14:59:48Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""C2F-wRHz1PV3GHHFl_MCwTMObzA"",
      ""id"": ""UgzVs79EYAHwSsNBmE14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""5YsxwXLC3Y1bhYjHo3CeowRxSSk"",
          ""id"": ""UgzVs79EYAHwSsNBmE14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=3m39s\""\u003e3:39\u003c/a\u003e оператор заржал)"",
            ""textOriginal"": ""3:39 оператор заржал)"",
            ""authorDisplayName"": ""Sergei Semenov"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnheWrCCFqvur-DzH-qFUcgZpvx7T77pH6vHtQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCAreCnxmQ1lV5_Rmr8s8h7w"",
            ""authorChannelId"": {
                    ""value"": ""UCAreCnxmQ1lV5_Rmr8s8h7w""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T14:59:14Z"",
            ""updatedAt"": ""2021-01-02T14:59:14Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""YOvL6Co24ZpENoBBmyPj9o8T6xY"",
      ""id"": ""UgwG-taSP2HTkpzJUm94AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""FzLJwIotgKvFbvIGJcqlsShYDFc"",
          ""id"": ""UgwG-taSP2HTkpzJUm94AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Отсутствие денег подталкивает к кидалову даже относительно честных людей. Проверено.\u003cbr /\u003eЛучше не злоупотреблять кредитом доверия. Всё хорошо вмеру."",
            ""textOriginal"": ""Отсутствие денег подталкивает к кидалову даже относительно честных людей. Проверено.\nЛучше не злоупотреблять кредитом доверия. Всё хорошо вмеру."",
            ""authorDisplayName"": ""Евгений Попов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjWNlqSJDtfVcHTf89DEBMBUuhfD9XKCxxpHA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCLF52vnAfBvK_HtiC8MfSiQ"",
            ""authorChannelId"": {
                    ""value"": ""UCLF52vnAfBvK_HtiC8MfSiQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T14:58:39Z"",
            ""updatedAt"": ""2021-01-02T14:58:39Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""vpoe3O68dp3nZTAOBqqd5tk7wEM"",
      ""id"": ""UgxvXW0xiLSPCQWOy_94AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""NsVS1s-2C-gBa7eJhrqU1MVZBbk"",
          ""id"": ""UgxvXW0xiLSPCQWOy_94AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Дэн стоит ли счас входить в биток или ждать коррекции, интересны твои мысли?"",
            ""textOriginal"": ""Дэн стоит ли счас входить в биток или ждать коррекции, интересны твои мысли?"",
            ""authorDisplayName"": ""xavi hernadez"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngXGP-tG-feipW1DFigj0qVU3lZWdiBl2W7LQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCXR667ltISiBcvbtdmhbOaA"",
            ""authorChannelId"": {
                    ""value"": ""UCXR667ltISiBcvbtdmhbOaA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 3,
            ""publishedAt"": ""2021-01-02T14:38:41Z"",
            ""updatedAt"": ""2021-01-02T14:38:41Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""mdwti7093CdVF4QWbAHzdOI2QBA"",
      ""id"": ""UgwX0QGKArgKKtXgNll4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""9EBotrRW12ZbcjMOVmT3g_0fIsY"",
          ""id"": ""UgwX0QGKArgKKtXgNll4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Дэн, похоже на чиновниках эта система не работает. Сколько бы не было у них денег, всё равно пиз..т миллиардами.😂"",
            ""textOriginal"": ""Дэн, похоже на чиновниках эта система не работает. Сколько бы не было у них денег, всё равно пиз..т миллиардами.😂"",
            ""authorDisplayName"": ""Maxim Leonidovich"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjfuR5jnOkaeIX5gWSui4OwqZyrRilMNK9CJBOssg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCQbuhAITLScAHHvtjWIu4PA"",
            ""authorChannelId"": {
                    ""value"": ""UCQbuhAITLScAHHvtjWIu4PA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T14:35:34Z"",
            ""updatedAt"": ""2021-01-02T14:35:34Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""8drQr-x_UEDX3DtfJA83PmrxZAE"",
      ""id"": ""UgwdGyj5aQF0XiFpy754AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""zpebSIarhVdNAqX64iDkkELfay0"",
          ""id"": ""UgwdGyj5aQF0XiFpy754AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""На всякий случай, изначально бодипозитив это когда ты не стесняешься своих врожденных/приобретённых недостатков, по типу родимых пятен на лице, отсутствие конечностей, шрамы и т.п. А потом уже жирухи подхватили и начали кричать что они не ленивые обжорливые сраки, а бодипозитивщицы."",
            ""textOriginal"": ""На всякий случай, изначально бодипозитив это когда ты не стесняешься своих врожденных/приобретённых недостатков, по типу родимых пятен на лице, отсутствие конечностей, шрамы и т.п. А потом уже жирухи подхватили и начали кричать что они не ленивые обжорливые сраки, а бодипозитивщицы."",
            ""authorDisplayName"": ""Vitaly P."",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngkaSGnVlfo1QxbWVECy63nf1pHl0a4epT2ug=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC56upUCi1Bm8VYsFjtdtZYQ"",
            ""authorChannelId"": {
                    ""value"": ""UC56upUCi1Bm8VYsFjtdtZYQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T14:33:43Z"",
            ""updatedAt"": ""2021-01-02T14:35:25Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""3UDUnN_DQfdDSpHO4V3MB1RUokA"",
      ""id"": ""Ugx13VPexwDppoptjiF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""yBziig8YIgZRnGC2RfIAlOS_1Gg"",
          ""id"": ""Ugx13VPexwDppoptjiF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""На постере кельвин кляйна, не толстая тетка, а жирный мужик переодетый в бабу."",
            ""textOriginal"": ""На постере кельвин кляйна, не толстая тетка, а жирный мужик переодетый в бабу."",
            ""authorDisplayName"": ""Магазин Спортивного Питания ProteinHouse"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniR4ZjdekdYU7sHdNOvlQM9_c0m_u9xHSCO8Q7iQA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCkOrFZcu3gN3Hwv4QcJuX6w"",
            ""authorChannelId"": {
                    ""value"": ""UCkOrFZcu3gN3Hwv4QcJuX6w""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T14:33:25Z"",
            ""updatedAt"": ""2021-01-02T14:33:25Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""uNVxlLjQ4sSwCtdSm01oI3QTWx4"",
      ""id"": ""Ugw7C1JY2cUhPC88V4V4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""mCCEnkfVwAManGRIRZDQAScKzCk"",
          ""id"": ""Ugw7C1JY2cUhPC88V4V4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, я тебе больше скажу - эта черная модель с плаката Calvin Klein  - она не только жирная. Она ещё и транс. Бывший мужик кароч. Зовут его/её/оно Jari Jones если что."",
            ""textOriginal"": ""Денис, я тебе больше скажу - эта черная модель с плаката Calvin Klein  - она не только жирная. Она ещё и транс. Бывший мужик кароч. Зовут его/её/оно Jari Jones если что."",
            ""authorDisplayName"": ""Рокфеллер Ротшильдов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjXiJmoy6cNsXbkBGOIRpPV9YjM_ayXpYe56PQY=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCsDDG1jOGGQkmqm-cURSdhQ"",
            ""authorChannelId"": {
                    ""value"": ""UCsDDG1jOGGQkmqm-cURSdhQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T14:32:18Z"",
            ""updatedAt"": ""2021-01-02T14:32:18Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""JVXw1YhgCBpBlsZ5IGbb5zvAnC8"",
      ""id"": ""Ugyvu3SMlZBRBupazaV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""Rwr2YF5GbQPdlurhsQQ0xscvSj4"",
          ""id"": ""Ugyvu3SMlZBRBupazaV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Кстати эта &quot;бодипозитивщица&quot; ещё и трансгендер"",
            ""textOriginal"": ""Кстати эта \""бодипозитивщица\"" ещё и трансгендер"",
            ""authorDisplayName"": ""Uranus"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjCrdXFzS8EEg-EoCiObMRe-Qfm5MjIR_vkmb6f=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UChfRnvtJCDG46rmct2oOxyQ"",
            ""authorChannelId"": {
                    ""value"": ""UChfRnvtJCDG46rmct2oOxyQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T14:31:56Z"",
            ""updatedAt"": ""2021-01-02T14:31:56Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""5DUfFa3B7kdIH5dt38sNIdwOLbU"",
      ""id"": ""UgztFktLPYBln_X-Xbd4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""u-OzSmIOiof1E-DBiQPow3b-OZA"",
          ""id"": ""UgztFktLPYBln_X-Xbd4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, здравствуй! Есть вопрос, кому интересно - поднимите в топ, чтобы увидел. Много сказано о том, что нужно вводить ограничения и я полностью поддерживаю эту мысль. Но столкнулся с тем, что без изменения образа мышления эти ограничения работают лишь определенное время, потом ждет неизбежный срыв и возвращение к предыдущему образу жизни. Как не возвращаться, а оставить изменения на постоянной основе?\u003cbr /\u003eЧитал или где-то от тебя услышал, что изменить образ мышления можно только в том случае, если есть в этом значительный смысл. То есть если я решил перестроить свое тело, но это не подкрепляется сильным убеждением &quot;Зачем мне это надо?&quot;, то меня ждет неудача. Объясни пожалуйста как и где найти сильное убеждение или как его развить, убеждение, которое будет сильнее, чем просто удовлетворение потребностей тела."",
            ""textOriginal"": ""Денис, здравствуй! Есть вопрос, кому интересно - поднимите в топ, чтобы увидел. Много сказано о том, что нужно вводить ограничения и я полностью поддерживаю эту мысль. Но столкнулся с тем, что без изменения образа мышления эти ограничения работают лишь определенное время, потом ждет неизбежный срыв и возвращение к предыдущему образу жизни. Как не возвращаться, а оставить изменения на постоянной основе?\nЧитал или где-то от тебя услышал, что изменить образ мышления можно только в том случае, если есть в этом значительный смысл. То есть если я решил перестроить свое тело, но это не подкрепляется сильным убеждением \""Зачем мне это надо?\"", то меня ждет неудача. Объясни пожалуйста как и где найти сильное убеждение или как его развить, убеждение, которое будет сильнее, чем просто удовлетворение потребностей тела."",
            ""authorDisplayName"": ""artyom demidenko"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwni1UlAVrhbzRUyfXlyzSBeQP30NrXlMR9cHJQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCIhMaSp_sZtvget2MFt9wyg"",
            ""authorChannelId"": {
                    ""value"": ""UCIhMaSp_sZtvget2MFt9wyg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T14:29:06Z"",
            ""updatedAt"": ""2021-01-02T14:29:06Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""UZ7u4EqZBJszR78q1ZRCf7wmmjs"",
      ""id"": ""UgzUFonqjra7X2P25X14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""EuEDHp6p_pp1vOL57ESZptaTjqs"",
          ""id"": ""UgzUFonqjra7X2P25X14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Фильм про этот самолёт есть. Они в конце собрали одного человека, который дошёл до цивилизации, а потом всех забрали."",
            ""textOriginal"": ""Фильм про этот самолёт есть. Они в конце собрали одного человека, который дошёл до цивилизации, а потом всех забрали."",
            ""authorDisplayName"": ""Алексей Козлов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhOPN1hbM_XvcXSamGR6FzYwOfQXod7mQCrShIPsg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCLtJSj8kKfJvvnuprIa-QrA"",
            ""authorChannelId"": {
                    ""value"": ""UCLtJSj8kKfJvvnuprIa-QrA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T14:27:18Z"",
            ""updatedAt"": ""2021-01-02T14:27:18Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""LJFmFwfhKBgH37wDuqVYp3DejXY"",
      ""id"": ""UgzqqClItHKOhmYZn994AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""lHQVmPcoJjVwR8nnGAQ00JnHmw0"",
          ""id"": ""UgzqqClItHKOhmYZn994AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, биток 30к спасибо за советы которые даешь! Скажи свое мнение по поводу альтов, как ты считаешь будет ли рост? И что думаешь по поводу ХRP, по новостному фону все плохо, но например Grayscale регулярно скупает его🤔"",
            ""textOriginal"": ""Денис, биток 30к спасибо за советы которые даешь! Скажи свое мнение по поводу альтов, как ты считаешь будет ли рост? И что думаешь по поводу ХRP, по новостному фону все плохо, но например Grayscale регулярно скупает его🤔"",
            ""authorDisplayName"": ""Vladislav BCC"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhakay6xUzOnt7F8k-TvnpFd8GxuwNIQlnZdUkl=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC3iifWGI5wWicdE02Ei9q7A"",
            ""authorChannelId"": {
                    ""value"": ""UC3iifWGI5wWicdE02Ei9q7A""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T14:22:27Z"",
            ""updatedAt"": ""2021-01-02T14:22:27Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""prZKknSB2D8Jy2D3QmiqJYyr84E"",
      ""id"": ""UgxUYVAip_rzU42Zdf54AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""zHyspvYnEFimsOK5UMeJZNDG3Ko"",
          ""id"": ""UgxUYVAip_rzU42Zdf54AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, привет! Очень тебя прошу расскажи про биток. Как думаешь сколько продолжатся бычьи настроения? Как думаешь сколько будет в конце 2021? Чувствую, что защëл надолго. Влил 100т.РФ на 25т.зелëных, результат радует))"",
            ""textOriginal"": ""Денис, привет! Очень тебя прошу расскажи про биток. Как думаешь сколько продолжатся бычьи настроения? Как думаешь сколько будет в конце 2021? Чувствую, что защëл надолго. Влил 100т.РФ на 25т.зелëных, результат радует))"",
            ""authorDisplayName"": ""Дмитрий Дунаев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngUZT_6JLwY39NSnGgm7Kv-uqJ8-eBUoV2Pz7oq_g=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCM2SCeI8ph_lJwv1wyhczEA"",
            ""authorChannelId"": {
                    ""value"": ""UCM2SCeI8ph_lJwv1wyhczEA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T14:19:13Z"",
            ""updatedAt"": ""2021-01-02T14:19:13Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""40lbGSJO2JU50uDEKYeCbfeCEqY"",
      ""id"": ""Ugzy8ADRYMeLqzVEgUZ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""WERhnCIcDltYWKkZvn4mFtCpvVQ"",
          ""id"": ""Ugzy8ADRYMeLqzVEgUZ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Спасибо вам Денис за приятную подачу полезной информации! Да прибудет с вами Сила в новом 2021 году ! :)"",
            ""textOriginal"": ""Спасибо вам Денис за приятную подачу полезной информации! Да прибудет с вами Сила в новом 2021 году ! :)"",
            ""authorDisplayName"": ""VETSIRDYA"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniLxZ-yKcpB8EolfsnM_JUsfI_qIZf5q8j0ZRUh=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCBNE_j212iUWUsh8q-yA6Sw"",
            ""authorChannelId"": {
                    ""value"": ""UCBNE_j212iUWUsh8q-yA6Sw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T14:16:26Z"",
            ""updatedAt"": ""2021-01-02T14:16:26Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Jh5olaZI5-aiwycs6oKvs-WIhxI"",
      ""id"": ""Ugx67pU7R6R_MNWhQMZ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""w8O6Fi4QvbgmWnWO_twyLupJc0o"",
          ""id"": ""Ugx67pU7R6R_MNWhQMZ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Кто ведется на рекламу-тот лох!"",
            ""textOriginal"": ""Кто ведется на рекламу-тот лох!"",
            ""authorDisplayName"": ""Аl Saur"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh5_zJzNlH2_gGj7pHVOdP7ayakfWt2EYyrjg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCiqWfuAGcvZxJdda9SzBXxg"",
            ""authorChannelId"": {
                    ""value"": ""UCiqWfuAGcvZxJdda9SzBXxg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T14:15:27Z"",
            ""updatedAt"": ""2021-01-02T14:15:27Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""UfSH7_o3roq6QdMFfGDiFnlztvU"",
      ""id"": ""UgwGgZw8UZhtyv6ioKl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""nqb2aU9pxGGxPANvyASt6WApKsk"",
          ""id"": ""UgwGgZw8UZhtyv6ioKl4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Россия очень нищая страна (про людей),поэтому и у нас пока что нищее мышление("",
            ""textOriginal"": ""Россия очень нищая страна (про людей),поэтому и у нас пока что нищее мышление("",
            ""authorDisplayName"": ""Ришат Гарипов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngG6Zc7RPdp6CeiczhX80aEy7OWNz0uROqpfg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCn0fZaJRGHM24R9ALKYqw8A"",
            ""authorChannelId"": {
                    ""value"": ""UCn0fZaJRGHM24R9ALKYqw8A""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T14:11:57Z"",
            ""updatedAt"": ""2021-01-02T14:11:57Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""bc0Zzdm86E3WltGl1wzzpGUkYDM"",
      ""id"": ""UgyQL6DGgpvP0IasGEp4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""PZ2zrbCHS1EZrzLpSqW4qC_6J7Q"",
          ""id"": ""UgyQL6DGgpvP0IasGEp4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=1m24s\""\u003e1:24\u003c/a\u003e Выбираю вторую 😈"",
            ""textOriginal"": ""1:24 Выбираю вторую 😈"",
            ""authorDisplayName"": ""Артем Голованов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhfH1Olk8Tgx5vybKd3VZMdyFyPvXuduqG9ZCkB=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC17CfBuJ77Swc8u5-YvINKg"",
            ""authorChannelId"": {
                    ""value"": ""UC17CfBuJ77Swc8u5-YvINKg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T14:07:30Z"",
            ""updatedAt"": ""2021-01-02T14:07:30Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""l3M86TUZsJpvPromEHGinoPFcaI"",
      ""id"": ""Ugy76GaWgTMEH66Vr-B4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""HmvVuB75XKsp3VG7CP-3NUuBZzk"",
          ""id"": ""Ugy76GaWgTMEH66Vr-B4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, я скачал бесплатно библию капиталиста. Отдам 200$ когда заработаю первый лям₽"",
            ""textOriginal"": ""Денис, я скачал бесплатно библию капиталиста. Отдам 200$ когда заработаю первый лям₽"",
            ""authorDisplayName"": ""хрен собачий"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjmGSzXF7aAjNZgkgp2fQbDkzHr1842U3lt705V=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC2Dos0IaO0C8W4qwsgDfa_w"",
            ""authorChannelId"": {
                    ""value"": ""UC2Dos0IaO0C8W4qwsgDfa_w""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T14:04:42Z"",
            ""updatedAt"": ""2021-01-02T14:04:42Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""5EkxTr9C9ViMkZRFFq_fysE16uA"",
      ""id"": ""UgxoWkdNN2j5MsPjVxd4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""XYO4E1RLA3YMzzV9ukP7dzG6ivI"",
          ""id"": ""UgxoWkdNN2j5MsPjVxd4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=34m25s\""\u003e34:25\u003c/a\u003e А государство кому подчиняется? Ты ведь не хочешь сказать, что народу?)))"",
            ""textOriginal"": ""34:25 А государство кому подчиняется? Ты ведь не хочешь сказать, что народу?)))"",
            ""authorDisplayName"": ""Postulo Optumis"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngaphQm29bmGEYG0doKpqqPi1SPkXdUikYuuJs7=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCcy_f0N5TdOBs7aC3osEmyw"",
            ""authorChannelId"": {
                    ""value"": ""UCcy_f0N5TdOBs7aC3osEmyw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T14:02:02Z"",
            ""updatedAt"": ""2021-01-02T14:02:02Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""QH_JMbP-4A2fCR7EZ7ypXQbinI8"",
      ""id"": ""UgySdLmExBInJs7zrXp4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ldV4j9avyMs9YvlB03ByN2FqCgY"",
          ""id"": ""UgySdLmExBInJs7zrXp4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Дэнчик, как всегда -- лайк за выпуск! \u003cbr /\u003eТолько два вопроса осталось:\u003cbr /\u003e• Когда исторический выпуск наконец? (С одной большой интересной историей)\u003cbr /\u003e• Как правильно называется символ на заглавной фотокарточке этого канала?\u003cbr /\u003eС Новым годом, Дэнчик)) Успехов тебе в этом году, мы тоже будем где-то рядышком с тобой, на твоём пути достижения целей с каналами и образовательной платформой))"",
            ""textOriginal"": ""Дэнчик, как всегда -- лайк за выпуск! \nТолько два вопроса осталось:\n• Когда исторический выпуск наконец? (С одной большой интересной историей)\n• Как правильно называется символ на заглавной фотокарточке этого канала?\nС Новым годом, Дэнчик)) Успехов тебе в этом году, мы тоже будем где-то рядышком с тобой, на твоём пути достижения целей с каналами и образовательной платформой))"",
            ""authorDisplayName"": ""Artyom Bogdanov"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhdIea6c0puD-ZyXMobotcYPFrXy-pnXCLcdMd7Wg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCTrnH14TlEWg_mwVshByCKw"",
            ""authorChannelId"": {
                    ""value"": ""UCTrnH14TlEWg_mwVshByCKw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T13:54:46Z"",
            ""updatedAt"": ""2021-01-02T13:54:46Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""VAgN_VtGsykEdgWrP86nKYs4fpw"",
      ""id"": ""UgwrSHTbAjC5pVdqmzF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""0apWZktXZaqRZVfyKxVEoYOVd5I"",
          ""id"": ""UgwrSHTbAjC5pVdqmzF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""В Америке вообще жесть с этим &quot;боди позитивом&quot;..."",
            ""textOriginal"": ""В Америке вообще жесть с этим \""боди позитивом\""..."",
            ""authorDisplayName"": ""Igor Romashchenko"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhf0CZfiqPVADvFErResDGlARoNi-jH1LdwgXoulA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC4cH6qvTpKUGcByRzASSpog"",
            ""authorChannelId"": {
                    ""value"": ""UC4cH6qvTpKUGcByRzASSpog""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T13:53:27Z"",
            ""updatedAt"": ""2021-01-02T13:53:27Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""__JyK_VFSDHgFV0fQve73QThS8w"",
      ""id"": ""Ugy3GKs3Ik8rOtSDi9t4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""T0YwNDzfiFeD7G4WStQARvtXrO4"",
          ""id"": ""Ugy3GKs3Ik8rOtSDi9t4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""По превью подумал, что денчик вернулся в стриптиз"",
            ""textOriginal"": ""По превью подумал, что денчик вернулся в стриптиз"",
            ""authorDisplayName"": ""Stepan Kulazhenkov"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniFeOCzoHXRD1o_hs-k-1tsyIYURmfN_g4dI2bGGw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCxlfan9sgYPxyXw7i0c8kQw"",
            ""authorChannelId"": {
                    ""value"": ""UCxlfan9sgYPxyXw7i0c8kQw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T13:51:16Z"",
            ""updatedAt"": ""2021-01-02T13:51:16Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""EtwS4Fqiuk57NCSwqnp14NECKNM"",
      ""id"": ""UgxQVRzhmti4LGcqmK54AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""5wTzOvOtfBeGd4boFloJo4wLjYk"",
          ""id"": ""UgxQVRzhmti4LGcqmK54AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денчик, это не просто жирная баба, это трансгендер ( жирный черный мужик стал &quot;бабой&quot;) просто имбовое комбо сегодняшнего дня"",
            ""textOriginal"": ""Денчик, это не просто жирная баба, это трансгендер ( жирный черный мужик стал \""бабой\"") просто имбовое комбо сегодняшнего дня"",
            ""authorDisplayName"": ""Артур"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniz4A_Nk_HxkqiKYoFVepuBFIQ5zeY0qDYdNDyAkg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCPpYXOVDtILv_CV9knyRvOA"",
            ""authorChannelId"": {
                    ""value"": ""UCPpYXOVDtILv_CV9knyRvOA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T13:50:51Z"",
            ""updatedAt"": ""2021-01-02T13:50:51Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""GjBzGYGocZH8POxqSVIL79h7iWU"",
      ""id"": ""UgxhnK_lkdpCayyrzNJ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""CKLd7hDkN_GE-CiejelCa1Q7vKk"",
          ""id"": ""UgxhnK_lkdpCayyrzNJ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Ден с тобой уже 6ть лет. В твоём образе питания присутствуют КАШИ, типо гречи, а это много глеводов, пусть да же и медленных. Почему ты не используешь СХЕМУ ПИТАНИЯ Алексея Ворона ПГ на Кето/Палео? И слышал ли ты вообще о ней?)"",
            ""textOriginal"": ""Ден с тобой уже 6ть лет. В твоём образе питания присутствуют КАШИ, типо гречи, а это много глеводов, пусть да же и медленных. Почему ты не используешь СХЕМУ ПИТАНИЯ Алексея Ворона ПГ на Кето/Палео? И слышал ли ты вообще о ней?)"",
            ""authorDisplayName"": ""BlagoDaren"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjQftX-yEmRX-cLqz2qhQPa57bNoQjF6yA54_M=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCP5wqG9aNmJBgjm6VTyBjXw"",
            ""authorChannelId"": {
                    ""value"": ""UCP5wqG9aNmJBgjm6VTyBjXw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T13:43:23Z"",
            ""updatedAt"": ""2021-01-02T13:43:23Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""GrguC0N_WdqXw4hopAoJmPPYFnI"",
      ""id"": ""UgyddagphvzlzR9d0Bt4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""wgjylLkiyZ9-lGvnkmLU67bNxss"",
          ""id"": ""UgyddagphvzlzR9d0Bt4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Я бы не пошел на свидание с девушкой с рекламы из 2020, потому что это не девушка, а Jari Jones"",
            ""textOriginal"": ""Я бы не пошел на свидание с девушкой с рекламы из 2020, потому что это не девушка, а Jari Jones"",
            ""authorDisplayName"": ""Svintil"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhQFBcM3sItskc94dYWRxWwpnilesk-WHp-CuA2=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCwWAS1iWvoIA-8jznXHNv9g"",
            ""authorChannelId"": {
                    ""value"": ""UCwWAS1iWvoIA-8jznXHNv9g""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T13:41:58Z"",
            ""updatedAt"": ""2021-01-02T13:41:58Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""o4c1tYlT5i4GmCIU6J-jGZUMW4I"",
      ""id"": ""UgzBxFZDrSadtoPiRBl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""TN2Pqdh1I2SJmkPmZr7aoKs0Hi4"",
          ""id"": ""UgzBxFZDrSadtoPiRBl4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денчик зубы отбелил?)"",
            ""textOriginal"": ""Денчик зубы отбелил?)"",
            ""authorDisplayName"": ""Артем Лукьянов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjVWkOh_BZ05tY9yU7oRnLrPBo3ikVuIl1m0g=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCMAfKPx_rDXaQLgZkI5cVDw"",
            ""authorChannelId"": {
                    ""value"": ""UCMAfKPx_rDXaQLgZkI5cVDw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T13:34:05Z"",
            ""updatedAt"": ""2021-01-02T13:34:05Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""wV8XZxLuvf9wS6kcbBSdcrcipZM"",
      ""id"": ""UgwAEEEiDySlzl6nMW14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""JtodWTvA02pe7EN0e30f74WZNFA"",
          ""id"": ""UgwAEEEiDySlzl6nMW14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Привет.  Биткоин уже 30 тыс. Когда ты думаешь будет  альтсезон ???"",
            ""textOriginal"": ""Привет.  Биткоин уже 30 тыс. Когда ты думаешь будет  альтсезон ???"",
            ""authorDisplayName"": ""Ivan Troyan"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjsWPR8Hfs8zOFM8joVJpRbDDCxv0waUtsz=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCaXjEewBxa2cUWKo3huSN6g"",
            ""authorChannelId"": {
                    ""value"": ""UCaXjEewBxa2cUWKo3huSN6g""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T13:26:00Z"",
            ""updatedAt"": ""2021-01-02T13:26:00Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""8xZ3nmM_pipFteQJGwkoOlxwAMY"",
      ""id"": ""UgztLICrQ4A3czCcFV14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""MAD8VtofCG0BlWObAKHaJQEgWrI"",
          ""id"": ""UgztLICrQ4A3czCcFV14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""На обложке Calvin Klein не просто женщина, Денис, это трансгендер"",
            ""textOriginal"": ""На обложке Calvin Klein не просто женщина, Денис, это трансгендер"",
            ""authorDisplayName"": ""Дмитрий"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjot1IViAgd-Esjnr85wKG1doE1rN3nHkCkJA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC3zIbgfjzjzA1D5JeeS2n1Q"",
            ""authorChannelId"": {
                    ""value"": ""UC3zIbgfjzjzA1D5JeeS2n1Q""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T13:25:06Z"",
            ""updatedAt"": ""2021-01-02T13:25:06Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""eJQMp20MGBB-tWon5z5-rDYl-Ek"",
      ""id"": ""Ugz11SF46UH0V63q2Lt4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""XjvF_osjuz4DjrD-G3ViZV8Ectc"",
          ""id"": ""Ugz11SF46UH0V63q2Lt4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денчик, спасибо за подарочек на днюху!"",
            ""textOriginal"": ""Денчик, спасибо за подарочек на днюху!"",
            ""authorDisplayName"": ""Владимир Куковякин"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjvl9HpfELoQdADbpnvKs1qNFcSkQEVnLqh3w=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCgYiGZnL5LxlUb6xTM-tWbQ"",
            ""authorChannelId"": {
                    ""value"": ""UCgYiGZnL5LxlUb6xTM-tWbQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T13:21:51Z"",
            ""updatedAt"": ""2021-01-02T13:21:51Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""QczB2nutCVzkwlW2u75TETU60yg"",
      ""id"": ""UgzT7I0FpjEJU511yqp4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""MKpfU1d8Qs8u22q_LLwwlHR5M9g"",
          ""id"": ""UgzT7I0FpjEJU511yqp4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, спасибо огромное! Очень полезные видео!"",
            ""textOriginal"": ""Денис, спасибо огромное! Очень полезные видео!"",
            ""authorDisplayName"": ""Alexander Abr"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngbkrGePERat2goGXiYsnSVTePKFtnf0CLak9L2uQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCrS4kcKtKWCsaaqtr3hbgFA"",
            ""authorChannelId"": {
                    ""value"": ""UCrS4kcKtKWCsaaqtr3hbgFA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T13:21:06Z"",
            ""updatedAt"": ""2021-01-02T13:21:06Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""nBggo4wkPVu6AMjlfY4qZ-gb-yo"",
      ""id"": ""UgwiErh8QXl6AnvXw0B4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""mny88VXa-T7NPnSzrF5CsBpOW_A"",
          ""id"": ""UgwiErh8QXl6AnvXw0B4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Дэнчик, снимай видео по-длинее. Не меньше часа. А то 45 минут, ну это мало."",
            ""textOriginal"": ""Дэнчик, снимай видео по-длинее. Не меньше часа. А то 45 минут, ну это мало."",
            ""authorDisplayName"": ""Anti Cheater"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjXfWtRlIkb1dbe2K1C5innFsFX-24opU6T9TEd=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCWPosjVXYvPmXMkppYZ2Gjw"",
            ""authorChannelId"": {
                    ""value"": ""UCWPosjVXYvPmXMkppYZ2Gjw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T13:17:50Z"",
            ""updatedAt"": ""2021-01-02T13:17:50Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""JJpDLrIxJJs_Kr4qSVD0h-QKn0I"",
      ""id"": ""Ugw4N4MojCvEBBDA7iR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""Fmj-ZzdEY9m_j3fdt_n-EIiLOxE"",
          ""id"": ""Ugw4N4MojCvEBBDA7iR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Про то что в США все поровну снова наглая ложь. Там бардак, но там не все поровну не надо врать."",
            ""textOriginal"": ""Про то что в США все поровну снова наглая ложь. Там бардак, но там не все поровну не надо врать."",
            ""authorDisplayName"": ""MrKr"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjk31MPca6_GafDevKFw4K2jxuVh0O1fN302Q=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCbQh_5ihcGvYwDDK0s7idYg"",
            ""authorChannelId"": {
                    ""value"": ""UCbQh_5ihcGvYwDDK0s7idYg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T13:08:43Z"",
            ""updatedAt"": ""2021-01-02T13:08:43Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""gdEeAE2wXFJGk106heqSBGYAvmE"",
      ""id"": ""UgyTkojaKsjxgf0cZTF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""oNZpqkMoeD7ymxrHZdb1lEDUOy4"",
          ""id"": ""UgyTkojaKsjxgf0cZTF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, замути обои для рабочего стола пк и смартфона в хорошем качестве с символикой)"",
            ""textOriginal"": ""Денис, замути обои для рабочего стола пк и смартфона в хорошем качестве с символикой)"",
            ""authorDisplayName"": ""Alex Voyt"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngsnaoXXv5GZU_lpqAYouhrCXtlgzcd6EVY7uLS=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCgA54icOyZPfao7XejLKltw"",
            ""authorChannelId"": {
                    ""value"": ""UCgA54icOyZPfao7XejLKltw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T13:06:40Z"",
            ""updatedAt"": ""2021-01-02T13:06:40Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""7aT3qhfkth0uxBSdRBfR5XXSdIE"",
      ""id"": ""Ugzbq-egnlNdlSrn72R4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""uVkMJ6CL0gYUwFmL4y9GHLQQ4RQ"",
          ""id"": ""Ugzbq-egnlNdlSrn72R4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Как всегда, время проведенное с пользой и интересом. Спасибо!"",
            ""textOriginal"": ""Как всегда, время проведенное с пользой и интересом. Спасибо!"",
            ""authorDisplayName"": ""Евгений Альбатрос"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngHPPLpgSVB7dAMwd2HvKCa9B1k7HJl0xR80g=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC-7eJR9a2SnrymbASz0pdrg"",
            ""authorChannelId"": {
                    ""value"": ""UC-7eJR9a2SnrymbASz0pdrg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:57:36Z"",
            ""updatedAt"": ""2021-01-02T12:57:36Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Mj4II9k7_8xbNaHBc35b-m2izug"",
      ""id"": ""UgxPZUBnKsTbsO9WRJV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""4Pdz67AIQPtKB2r31pvF97CUmh8"",
          ""id"": ""UgxPZUBnKsTbsO9WRJV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Почему не поздравил нас, Денчик?)"",
            ""textOriginal"": ""Почему не поздравил нас, Денчик?)"",
            ""authorDisplayName"": ""Роман Бодров"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjVSUjryeVbG-PYAjZHtCsFwQc0FNiPoeNhfUghUg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCY6R3Y8ZFP3X2LSiYLFt71Q"",
            ""authorChannelId"": {
                    ""value"": ""UCY6R3Y8ZFP3X2LSiYLFt71Q""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:57:28Z"",
            ""updatedAt"": ""2021-01-02T12:57:28Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""AmCvmOSGcFMn0EB4tlia4naIzcs"",
      ""id"": ""UgwSF_qAKI7HADufuW54AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""YERL_xGm3EUlWTuFzLEaDPbNkNI"",
          ""id"": ""UgwSF_qAKI7HADufuW54AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Есть у нее еще отличие ,кроме ожирения )) \u003cbr /\u003eафроамериканец транс Яри Джонс"",
            ""textOriginal"": ""Есть у нее еще отличие ,кроме ожирения )) \nафроамериканец транс Яри Джонс"",
            ""authorDisplayName"": ""Bek Etov"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniCO0FVd3kUgwMUH4NFEj7373CAlBEaI-7wbLJEhQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCvoI3SCry54_1NPf7m3WLfQ"",
            ""authorChannelId"": {
                    ""value"": ""UCvoI3SCry54_1NPf7m3WLfQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 3,
            ""publishedAt"": ""2021-01-02T12:53:00Z"",
            ""updatedAt"": ""2021-01-02T12:53:00Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""sxA_xx8kuX_8eRZ_xbeVsKs6lmM"",
      ""id"": ""UgxYoLisB4yvGFXhxYV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""5uzgjKUhgQWiQhI9HZRGTukcOHU"",
          ""id"": ""UgxYoLisB4yvGFXhxYV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Авто лайк и авто пост"",
            ""textOriginal"": ""Авто лайк и авто пост"",
            ""authorDisplayName"": ""Виктор Заворошкин"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwni4Zkx6ewOIID68E5OdCBNND4cuqm9HK6A4-9R9=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC4C8JtKPuPzpq4WMFJD0V3g"",
            ""authorChannelId"": {
                    ""value"": ""UC4C8JtKPuPzpq4WMFJD0V3g""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:50:04Z"",
            ""updatedAt"": ""2021-01-02T12:50:04Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""ELLKJ73px0rTfRA3nx3_d4PC6AA"",
      ""id"": ""UgxjgvebYudtnuLTvI54AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""gS8XosYlO4xXorx_8Sqq6UmSY2Q"",
          ""id"": ""UgxjgvebYudtnuLTvI54AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=00h37m23s\""\u003e00:37:23\u003c/a\u003e на эту тему есть довольно интересное кино от netflix - &quot;El hoyo&quot;"",
            ""textOriginal"": ""00:37:23 на эту тему есть довольно интересное кино от netflix - \""El hoyo\"""",
            ""authorDisplayName"": ""Павел Осадчих"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhAjSBL3lOwhLJz8nHNeih2FSt2HihthvQ1MqzV=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCiHv1fI9_wHuwyHMY6yW_-A"",
            ""authorChannelId"": {
                    ""value"": ""UCiHv1fI9_wHuwyHMY6yW_-A""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:48:29Z"",
            ""updatedAt"": ""2021-01-02T12:48:29Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""msf_qj9svS9UpYWlKp91miUa9Os"",
      ""id"": ""Ugy2B5UpdmdfX9TDqcV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""qMWvodkVeBML7LkWusBFCSlv6nM"",
          ""id"": ""Ugy2B5UpdmdfX9TDqcV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Ден, не хочу тебя огорчать, но из этих двух... девушек. Я пожалуй всё же выберу именно девушку, а не транса с ожирением. Похоже я не толерантный."",
            ""textOriginal"": ""Ден, не хочу тебя огорчать, но из этих двух... девушек. Я пожалуй всё же выберу именно девушку, а не транса с ожирением. Похоже я не толерантный."",
            ""authorDisplayName"": ""Весарион Кел"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniLTM4Rymf2umBAoQc5oOJtg7FcHGCPC9kOMoqq=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCKoX0b07eWb0dlVuUdNibDw"",
            ""authorChannelId"": {
                    ""value"": ""UCKoX0b07eWb0dlVuUdNibDw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:47:47Z"",
            ""updatedAt"": ""2021-01-02T12:47:47Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""e8pUmnxK3Ic9RyDA6GIycflR-b0"",
      ""id"": ""Ugz0Hd0z28Y1XTxv8KV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""jDrhG9GUXWSf5l8Jd4dDXCOrQAk"",
          ""id"": ""Ugz0Hd0z28Y1XTxv8KV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Спасибо Дэн за то что ты делаешь)"",
            ""textOriginal"": ""Спасибо Дэн за то что ты делаешь)"",
            ""authorDisplayName"": ""Георгий Плюгин"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjA40wfkEHIzR-iePn_tIt8aSd7c_WSBTwCa-lY8bM=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCK7NvF1tKfRACCPj84720cQ"",
            ""authorChannelId"": {
                    ""value"": ""UCK7NvF1tKfRACCPj84720cQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:47:42Z"",
            ""updatedAt"": ""2021-01-02T12:47:42Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""01RVl9gtcPGolEDsKG86Pwug4YU"",
      ""id"": ""UgxTTNkMjJI0kgW3iyB4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""iSvubGayS0rspRICkXVPXDz2RiA"",
          ""id"": ""UgxTTNkMjJI0kgW3iyB4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Про убеждения с достатком и то что &quot;все возможно&quot; Жак Фреско много говорил. Понятно что у него тоже много хейтеров, но идея как я понял такая же была. Денис, спасибо за полезную инфу, как всегда."",
            ""textOriginal"": ""Про убеждения с достатком и то что \""все возможно\"" Жак Фреско много говорил. Понятно что у него тоже много хейтеров, но идея как я понял такая же была. Денис, спасибо за полезную инфу, как всегда."",
            ""authorDisplayName"": ""Сергей Ковалев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjLTJmhj0JbmzB0OTcnLOLtOCnLRWMBcsiRfH61=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UClfw3CgBLcTYaZHTn4wn0XQ"",
            ""authorChannelId"": {
                    ""value"": ""UClfw3CgBLcTYaZHTn4wn0XQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:44:26Z"",
            ""updatedAt"": ""2021-01-02T12:44:26Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""PX0CjOUZnsM4vjGooVouDJOwJ8U"",
      ""id"": ""UgygnGukRUJMw-ydLMF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""_x_kKLBGDBn4DFAYNeX1sKAeYD4"",
          ""id"": ""UgygnGukRUJMw-ydLMF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""А кто вам сказал что в мусульманских странах женщина как интерьер? Что хирня у тебя в голове?))"",
            ""textOriginal"": ""А кто вам сказал что в мусульманских странах женщина как интерьер? Что хирня у тебя в голове?))"",
            ""authorDisplayName"": ""M S"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhroRK0OXg5iPZEGMKRIbwTERrod_kGPF19R4KJjg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCPDgbP1v-xdESOYlcPVRIBw"",
            ""authorChannelId"": {
                    ""value"": ""UCPDgbP1v-xdESOYlcPVRIBw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:43:56Z"",
            ""updatedAt"": ""2021-01-02T12:43:56Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""8g7d7U2Le2Sns7aFI4FLRbEiARQ"",
      ""id"": ""UgwU4je-jxynuLhb7s14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""TXwfLBw7KJLyBDCqIulDOxxVCzA"",
          ""id"": ""UgwU4je-jxynuLhb7s14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Где закрыты потребности, там появляются Илоны Маски.\u003cbr /\u003eЯ не думаю что Тесла - пузырь. По тому что дела этой компании многим нравятся. Так же как и биткоин."",
            ""textOriginal"": ""Где закрыты потребности, там появляются Илоны Маски.\nЯ не думаю что Тесла - пузырь. По тому что дела этой компании многим нравятся. Так же как и биткоин."",
            ""authorDisplayName"": ""Лёха Хорошутин"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniAK2__OKu5-Yes37pDkoBRB60Ah7tHiNqsOA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCLGlMjej_LvS4gOSi7Om-2g"",
            ""authorChannelId"": {
                    ""value"": ""UCLGlMjej_LvS4gOSi7Om-2g""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:42:35Z"",
            ""updatedAt"": ""2021-01-02T12:42:35Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""-Yf_GZBh3MDVe3IFabWIz7wKmV0"",
      ""id"": ""UgxmITqiavSYcqMSIHV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""M0JTjXej5zPqbHAKXCbbvjr0-sU"",
          ""id"": ""UgxmITqiavSYcqMSIHV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""очень понравился выпуск"",
            ""textOriginal"": ""очень понравился выпуск"",
            ""authorDisplayName"": ""S0k0l0k"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj4d0UT6p3P7ogs0YBCJY-6FGfziI39Kf2ncg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC0_QOlJQwvK-Ma7vGlxeo_g"",
            ""authorChannelId"": {
                    ""value"": ""UC0_QOlJQwvK-Ma7vGlxeo_g""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:36:34Z"",
            ""updatedAt"": ""2021-01-02T12:36:34Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""YrKM2XIum6ZeOtN3acA6gPTocjo"",
      ""id"": ""UgyRvYWR67ykQi_jTWV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""nOR6cN94jkWXT50rpRZNklF4ctQ"",
          ""id"": ""UgyRvYWR67ykQi_jTWV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Как всегда, очень интересно Денис, спасибо что делаешь мировозрение шире) всех благ тебе и каналу твоему!"",
            ""textOriginal"": ""Как всегда, очень интересно Денис, спасибо что делаешь мировозрение шире) всех благ тебе и каналу твоему!"",
            ""authorDisplayName"": ""Александр Новоселов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnic5NSLg7Mqi4gM8OwBTioZJPTi9zrxrTFrvw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCdFCES9lpmASGT5mKczQWsg"",
            ""authorChannelId"": {
                    ""value"": ""UCdFCES9lpmASGT5mKczQWsg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T12:34:40Z"",
            ""updatedAt"": ""2021-01-02T12:34:40Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""1iSt8vfuN-GfVFyi_16zMS9FtAw"",
      ""id"": ""UgyBIscpZm_OKcELP_l4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""eMbaFO4BihGek3HeCws89By2f_M"",
          ""id"": ""UgyBIscpZm_OKcELP_l4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис спасибо, успехов и баланса в новом году. Удача тебе не нужна, у тебя татуировка есть)"",
            ""textOriginal"": ""Денис спасибо, успехов и баланса в новом году. Удача тебе не нужна, у тебя татуировка есть)"",
            ""authorDisplayName"": ""Егор Лазука"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjdLRMWYXz1aUePLDy_U--gpKCDjmF_Oj14VIhr=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCCTjLu5uYjJuHlYkDtkHLdg"",
            ""authorChannelId"": {
                    ""value"": ""UCCTjLu5uYjJuHlYkDtkHLdg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:32:13Z"",
            ""updatedAt"": ""2021-01-02T12:32:13Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""b4Z4o9Pq9ZkMiJP5vTQXrtpeaJU"",
      ""id"": ""Ugwk-nnpaO8fHcKFpdR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""2szYacNP1frVUrw7XN-KwrjRO-0"",
          ""id"": ""Ugwk-nnpaO8fHcKFpdR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Есть только одна проблема. МД никому проблем не доставляют, в отличии от фемок, и не кричат об этом из всех утюгов. И я не сторонник МД, если что."",
            ""textOriginal"": ""Есть только одна проблема. МД никому проблем не доставляют, в отличии от фемок, и не кричат об этом из всех утюгов. И я не сторонник МД, если что."",
            ""authorDisplayName"": ""draackul"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniHBhoVAkJdP1tajS4EzOnsLQ9YXclrfUfDNZDS=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCcRZ2BRRT0NKR2Jih12Oxzg"",
            ""authorChannelId"": {
                    ""value"": ""UCcRZ2BRRT0NKR2Jih12Oxzg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:29:56Z"",
            ""updatedAt"": ""2021-01-02T12:29:56Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Y5BYOlfKG6A0hyEqiUg3sgvqf-0"",
      ""id"": ""UgxeLKGe-dxBJfTwZwB4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""qEbncH-OFipsMiGL4ZDRyNiIJzs"",
          ""id"": ""UgxeLKGe-dxBJfTwZwB4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Детройт пошёл в упадок ещё в 50 е годы .по переписи почти два миилиона в 1950 а в 1960 уже стало полтора и дальше ещё меньше )это естественный экономический процесс."",
            ""textOriginal"": ""Детройт пошёл в упадок ещё в 50 е годы .по переписи почти два миилиона в 1950 а в 1960 уже стало полтора и дальше ещё меньше )это естественный экономический процесс."",
            ""authorDisplayName"": ""Эпицентр"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhkZzuzCukLmvpLA_tXIGKRHWCmIg_WErwbrw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCx4CgAS0tsmSDN3RTxQyg8Q"",
            ""authorChannelId"": {
                    ""value"": ""UCx4CgAS0tsmSDN3RTxQyg8Q""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:28:36Z"",
            ""updatedAt"": ""2021-01-02T12:28:36Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""ujsCp7mAfQRBQ6ah5bcd5gkF-IU"",
      ""id"": ""UgxMsq_q71oqU2jF2DF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ZKY-SKm_B2CgavqIaFG3xWFyHHg"",
          ""id"": ""UgxMsq_q71oqU2jF2DF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Спасибо. Все круто только при перебивке можно звук немного убавить искорёживание когда происходит. А так все классно все понравилось. Лайк."",
            ""textOriginal"": ""Спасибо. Все круто только при перебивке можно звук немного убавить искорёживание когда происходит. А так все классно все понравилось. Лайк."",
            ""authorDisplayName"": ""[FM] Force Majeure"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjoV0H5H3PcU6w-FtupBHdiOrWEMAaDTCIfTk3Xcw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCPtJyOT0BeM2byoG6nFJ19Q"",
            ""authorChannelId"": {
                    ""value"": ""UCPtJyOT0BeM2byoG6nFJ19Q""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:26:36Z"",
            ""updatedAt"": ""2021-01-02T12:26:36Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""VpO5Ru7Dn2lZdKbLQLvoScIdEEQ"",
      ""id"": ""UgyUu2IEVsHNQfZEeVN4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""gjQAS-5D9UVOsEwsOvrM-mb7jWE"",
          ""id"": ""UgyUu2IEVsHNQfZEeVN4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денчик давай в президенты)"",
            ""textOriginal"": ""Денчик давай в президенты)"",
            ""authorDisplayName"": ""velkozz z"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj5b7RwNt06vYZK-8DufX2tSEb0hVzCFQQmcw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCY70mcm7PvSF9Iwfm0DWk7A"",
            ""authorChannelId"": {
                    ""value"": ""UCY70mcm7PvSF9Iwfm0DWk7A""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:23:30Z"",
            ""updatedAt"": ""2021-01-02T12:23:30Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""447ieg3wO03rOsIBU95ijgNluCo"",
      ""id"": ""UgyNx1h4xtncWg__kPt4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""64x3F2EIIFYR9gFg7XQrDEfyzhY"",
          ""id"": ""UgyNx1h4xtncWg__kPt4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Про жирных актуально только по Европе и США, частично Азии - Африка другой расклад совсем, там испокон веков толстая женщина - предмет роскоши."",
            ""textOriginal"": ""Про жирных актуально только по Европе и США, частично Азии - Африка другой расклад совсем, там испокон веков толстая женщина - предмет роскоши."",
            ""authorDisplayName"": ""Aleksey Churilov"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh_i9ALNCr-3bU5YtF6puL9-v-lCxychdl_YPLxiQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC_R_qnZ5djutZlW3pXiFkZw"",
            ""authorChannelId"": {
                    ""value"": ""UC_R_qnZ5djutZlW3pXiFkZw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:23:29Z"",
            ""updatedAt"": ""2021-01-02T12:23:29Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""mRUMwYDTuxB1f5WdDXy-h4k8W3E"",
      ""id"": ""UgyKXbC9fJfEqevrXZN4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""TgJgVC96h1rMDvT3-EGzSw3xL-4"",
          ""id"": ""UgyKXbC9fJfEqevrXZN4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Мну любил полненьких/жирненьких ещё до того, как это стало мейнстримом..."",
            ""textOriginal"": ""Мну любил полненьких/жирненьких ещё до того, как это стало мейнстримом..."",
            ""authorDisplayName"": ""Игорь Демидов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnguvMC8u1_SNa1b76l2DYJhG7LCicUzGgkP_A=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCl627eKjSaAKhI2cSNCTTbg"",
            ""authorChannelId"": {
                    ""value"": ""UCl627eKjSaAKhI2cSNCTTbg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 3,
            ""publishedAt"": ""2021-01-02T12:22:31Z"",
            ""updatedAt"": ""2021-01-02T12:22:31Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""kgJYTdchMZukTQD-csUDLBuzUA0"",
      ""id"": ""UgwsZ5YteatC6VJGHpB4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""Vwpbf_fziHvFp43k2hxaB4m5sf8"",
          ""id"": ""UgwsZ5YteatC6VJGHpB4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Дэн, расскажи про СОЗДАТЕЛЕЙ БИТКОИНА🕵🏻\u200d♂️"",
            ""textOriginal"": ""Дэн, расскажи про СОЗДАТЕЛЕЙ БИТКОИНА🕵🏻\u200d♂️"",
            ""authorDisplayName"": ""Dmitry Fomenko"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngJZJu5xzyDydbVnY6ddbJr5EsnH5XYmq-vErkQyg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCLWuW4WHGM3jFtUz6MeN3WQ"",
            ""authorChannelId"": {
                    ""value"": ""UCLWuW4WHGM3jFtUz6MeN3WQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 3,
            ""publishedAt"": ""2021-01-02T12:22:12Z"",
            ""updatedAt"": ""2021-01-02T12:22:12Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""WLcOeVm6UIKVUcP6FwxROdClNvs"",
      ""id"": ""UgyqYRiCFZVv6qLWbg54AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""cfmTu8x2ukLhLts0O71zI8kwOj4"",
          ""id"": ""UgyqYRiCFZVv6qLWbg54AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис , друг, кто твой КУРАТОР ?....\u003cbr /\u003e Ты интересный чувак , но кто тобой рулит и нами ?"",
            ""textOriginal"": ""Денис , друг, кто твой КУРАТОР ?....\n Ты интересный чувак , но кто тобой рулит и нами ?"",
            ""authorDisplayName"": ""Ярик Лу"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjz3KUW5BN9IJ519HdDzH3cmMFW70OscCJ67E9s=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCVSExl7G4W4k1BRNLxA11UQ"",
            ""authorChannelId"": {
                    ""value"": ""UCVSExl7G4W4k1BRNLxA11UQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:19:52Z"",
            ""updatedAt"": ""2021-01-02T12:19:52Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""8yJeg75AGj7cR6KI6O7FGl-l03M"",
      ""id"": ""UgyxdVRC3az6e8glpuV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""cIdFWhcAe18IHPuf0Hl-bYJwaD4"",
          ""id"": ""UgyxdVRC3az6e8glpuV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, есть ли смысл в майнинге в 2021? Камрады, поддержите лайками!"",
            ""textOriginal"": ""Денис, есть ли смысл в майнинге в 2021? Камрады, поддержите лайками!"",
            ""authorDisplayName"": ""Александр Лукьянов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwng2mnF4mvPQxIYK3VOnEHmI6n1nHu0AuiEytaIpFw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCCkqyw2uZmqFtiu9XFf0gpA"",
            ""authorChannelId"": {
                    ""value"": ""UCCkqyw2uZmqFtiu9XFf0gpA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 3,
            ""publishedAt"": ""2021-01-02T12:19:19Z"",
            ""updatedAt"": ""2021-01-02T12:19:19Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""DSzk5Dxkskwe3K_UUq4PX56MnGU"",
      ""id"": ""UgyrAD67zpnKNlGLxtB4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ozhSSmV-JseYVOXstyg51P3yR2Q"",
          ""id"": ""UgyrAD67zpnKNlGLxtB4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Благодарю от Души"",
            ""textOriginal"": ""Благодарю от Души"",
            ""authorDisplayName"": ""Игорь Демидов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnguvMC8u1_SNa1b76l2DYJhG7LCicUzGgkP_A=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCl627eKjSaAKhI2cSNCTTbg"",
            ""authorChannelId"": {
                    ""value"": ""UCl627eKjSaAKhI2cSNCTTbg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:18:30Z"",
            ""updatedAt"": ""2021-01-02T12:18:30Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""KtnqXWGoK1xKiDNtrBXVFm_iUMw"",
      ""id"": ""UgwBrLFZuGgBNJ8pbud4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""oS4zrY3wvdY9yxXc5Qb5WPGTlbM"",
          ""id"": ""UgwBrLFZuGgBNJ8pbud4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Обычно не пишу комментарии, но тут исключение, БОЛЬШОЕ СПАСИБИЩЕ Денис, вправляет мозг в нужном направлении\u003cbr /\u003eС Новым Годом!!!"",
            ""textOriginal"": ""Обычно не пишу комментарии, но тут исключение, БОЛЬШОЕ СПАСИБИЩЕ Денис, вправляет мозг в нужном направлении\nС Новым Годом!!!"",
            ""authorDisplayName"": ""Triple"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhh1OTt9BmVrZvSuFw18fjeY8gh-0F7RDkgRFNdeA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC-ZwDrZc-QNKEGyKg2fCK1A"",
            ""authorChannelId"": {
                    ""value"": ""UC-ZwDrZc-QNKEGyKg2fCK1A""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:13:05Z"",
            ""updatedAt"": ""2021-01-02T12:13:05Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""bLzigdDRZuNwpyYXIpPRVT8neVs"",
      ""id"": ""Ugx_LJcpeIyaytCDaLt4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""Pbi4Yfi-pD5wdX4wOwxz_rCMeYI"",
          ""id"": ""Ugx_LJcpeIyaytCDaLt4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""не корона бро? \u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=22m21s\""\u003e22:21\u003c/a\u003e"",
            ""textOriginal"": ""не корона бро? 22:21"",
            ""authorDisplayName"": ""Gans Liber"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhpx2uCj2DX0Ns6A82pudlwdhFSEmGSERs3AII=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCUpMaK3wfzOfqaybJ7j0Reg"",
            ""authorChannelId"": {
                    ""value"": ""UCUpMaK3wfzOfqaybJ7j0Reg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:04:06Z"",
            ""updatedAt"": ""2021-01-02T12:04:06Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""lbBIAJFUy2KDDigsU_nOod4uT1o"",
      ""id"": ""Ugxyyt2orsglDHeXazV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""Z-JCri8BILFp9WrPfvZBLk-NNyM"",
          ""id"": ""Ugxyyt2orsglDHeXazV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Те, которые остались сидеть не умерли, за ними прислали вертушку те, которые пошли помощь искать. Ну по крайней мере так было в фильме снятом о этой истории. &quot;Выжить&quot; (Alive 1992) называется"",
            ""textOriginal"": ""Те, которые остались сидеть не умерли, за ними прислали вертушку те, которые пошли помощь искать. Ну по крайней мере так было в фильме снятом о этой истории. \""Выжить\"" (Alive 1992) называется"",
            ""authorDisplayName"": ""Владислав Голубев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjPU2GxQRRUvdfRLa1nwtzsbbRc9y3Y60Up937m=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCfpedJxB8pg3WI3ZQxNGU1g"",
            ""authorChannelId"": {
                    ""value"": ""UCfpedJxB8pg3WI3ZQxNGU1g""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:02:19Z"",
            ""updatedAt"": ""2021-01-02T12:06:11Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""FehlNl2yzUT8GswkY-3XQvHANZg"",
      ""id"": ""UgwlU7gN4qcfwmowO294AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""83io6ZIHlzHBV4-512kyNxLwbaU"",
          ""id"": ""UgwlU7gN4qcfwmowO294AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Очень. ОЧЕНЬ ИНТЕРЕСНЫЕ И ПОЗНАВАТЕЛЬНЫЕ ролики у Дениса. Спасибо огромное за творчество, Денис! Позитива и успеха тебе в новом году"",
            ""textOriginal"": ""Очень. ОЧЕНЬ ИНТЕРЕСНЫЕ И ПОЗНАВАТЕЛЬНЫЕ ролики у Дениса. Спасибо огромное за творчество, Денис! Позитива и успеха тебе в новом году"",
            ""authorDisplayName"": ""Енот Линьтяй"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh-dU_S2NNpBjNmagXMa8e_kSQJMOF99uFd-BFH=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCuM_OSw_VqlDhRTsNJNh-kQ"",
            ""authorChannelId"": {
                    ""value"": ""UCuM_OSw_VqlDhRTsNJNh-kQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T12:01:57Z"",
            ""updatedAt"": ""2021-01-02T12:02:18Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""QubaADf7CihQt0pHj2wYOmD-F6k"",
      ""id"": ""UgywmJNEphUnRxlQs814AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""eyQH0yDxNLtmfkb977PpjQhLb9Q"",
          ""id"": ""UgywmJNEphUnRxlQs814AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""жирных с каждым годом всё больше, реклама бадипозитива - дальновидная реклама, а фитнес скоро опять из моды выйдет)"",
            ""textOriginal"": ""жирных с каждым годом всё больше, реклама бадипозитива - дальновидная реклама, а фитнес скоро опять из моды выйдет)"",
            ""authorDisplayName"": ""УТКА ПРОСТИТУТКА"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwng1YGKZdv_I7SEEnLsDpNdBJqAvoXQGf56WXRUB=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UClaFWPRO-q4HcG6UXcKLPxw"",
            ""authorChannelId"": {
                    ""value"": ""UClaFWPRO-q4HcG6UXcKLPxw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:58:23Z"",
            ""updatedAt"": ""2021-01-02T11:58:23Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""b6vnGRq8TJK-UzgeCZiZDOvzftA"",
      ""id"": ""UgxvcOoFzTFFy8fMkwh4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""DmPrPpgeZgNUr_qukW6Czws2AT0"",
          ""id"": ""UgxvcOoFzTFFy8fMkwh4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Блин Ден я думал на превьюшке это ты, а не бодипозитивщица) no offensive)"",
            ""textOriginal"": ""Блин Ден я думал на превьюшке это ты, а не бодипозитивщица) no offensive)"",
            ""authorDisplayName"": ""Павел Васьков"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniUAKbe61pc9398nufNS18fZAZtd-JFptpZXG63=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC8Slgm52-KqnQTG-KLvwVfQ"",
            ""authorChannelId"": {
                    ""value"": ""UC8Slgm52-KqnQTG-KLvwVfQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:55:05Z"",
            ""updatedAt"": ""2021-01-02T12:35:11Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""v0pjpN4U4E31_xUS9UUymdVFhVA"",
      ""id"": ""UgxMs2ggquCqtmASn214AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""PtvszYMpBnbzw3B7tUXH6It_1-c"",
          ""id"": ""UgxMs2ggquCqtmASn214AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Диз за неадекватность."",
            ""textOriginal"": ""Диз за неадекватность."",
            ""authorDisplayName"": ""MrKr"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjk31MPca6_GafDevKFw4K2jxuVh0O1fN302Q=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCbQh_5ihcGvYwDDK0s7idYg"",
            ""authorChannelId"": {
                    ""value"": ""UCbQh_5ihcGvYwDDK0s7idYg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:50:26Z"",
            ""updatedAt"": ""2021-01-02T11:50:26Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""l2sm1lmMRBenXBfeb-wB904-cLY"",
      ""id"": ""UgynqlLrPTER_Bpy98N4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""e8jQrjJz1MPVK4Klgqbk92qPnZU"",
          ""id"": ""UgynqlLrPTER_Bpy98N4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Контент интересный! Развивай этот канал, Дэнчик, только не бросай."",
            ""textOriginal"": ""Контент интересный! Развивай этот канал, Дэнчик, только не бросай."",
            ""authorDisplayName"": ""sloppy joe"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhKKwpvMggNibPMgTP59atmpxIsQm8N8TFV_GmALw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCvbnCVwisL6GYJleuM6iQYA"",
            ""authorChannelId"": {
                    ""value"": ""UCvbnCVwisL6GYJleuM6iQYA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 3,
            ""publishedAt"": ""2021-01-02T11:48:15Z"",
            ""updatedAt"": ""2021-01-02T11:48:15Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""aDQaUwYo1hnuOEZUkNYTzIW-YNU"",
      ""id"": ""UgxySMQzb8i6rhViBlh4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""qrdhUWCw1BLXkEcKWU7ybr4-Cjo"",
          ""id"": ""UgxySMQzb8i6rhViBlh4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Привет, спасибо за позитив в новом году👍"",
            ""textOriginal"": ""Привет, спасибо за позитив в новом году👍"",
            ""authorDisplayName"": ""Andre Nickel"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnisqNUjphBk9Wp9S2007ad5AC-go-T7YaBElg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCqtkJQU5zh3vEBI9BHRqnzg"",
            ""authorChannelId"": {
                    ""value"": ""UCqtkJQU5zh3vEBI9BHRqnzg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:47:27Z"",
            ""updatedAt"": ""2021-01-02T11:47:27Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""m2gpJcE4Pv1hKZVcOcKTygsfXWM"",
      ""id"": ""UgwVA1pS6v52OK-Y0Zl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""vOvmlY84sNr-9EiGZZOwV_KoJ88"",
          ""id"": ""UgwVA1pS6v52OK-Y0Zl4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""«Библия капиталиста»- одно из лучших вложений в прошедшем году. В этом году будет много практики, чую;)\u003cbr /\u003eЕдинственное: понимаю, что редактора для пдф файла нанимать западло. Но очепятки я бы сам поправил за символическую сумму, просто по ходу чтения. Чтобы продукт выглядил целостным, без досадных дешевостей.\u003cbr /\u003eБлагодарность за деятельность, без б , в любом случае👍"",
            ""textOriginal"": ""«Библия капиталиста»- одно из лучших вложений в прошедшем году. В этом году будет много практики, чую;)\nЕдинственное: понимаю, что редактора для пдф файла нанимать западло. Но очепятки я бы сам поправил за символическую сумму, просто по ходу чтения. Чтобы продукт выглядил целостным, без досадных дешевостей.\nБлагодарность за деятельность, без б , в любом случае👍"",
            ""authorDisplayName"": ""Дмитрий Поваляев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh8pejnHMmXAka5hv2HAQFT1CRa3ED2MLtK77kguA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCDvAyW1Wy04w8qKkuF6u6aA"",
            ""authorChannelId"": {
                    ""value"": ""UCDvAyW1Wy04w8qKkuF6u6aA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:45:31Z"",
            ""updatedAt"": ""2021-01-02T11:45:31Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""X_DmO59EDVyAr77gsncJ6MV0rgA"",
      ""id"": ""UgyLMoalLRInbC2gA9B4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""eH-k8mtFM8i4dzf0cSiyA92-oao"",
          ""id"": ""UgyLMoalLRInbC2gA9B4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""С Новым годом, Брат!!!"",
            ""textOriginal"": ""С Новым годом, Брат!!!"",
            ""authorDisplayName"": ""Тимур Ахмадуллин"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhSXu1U3tYXw9wjlUO1v89gnhoMqbagOnx99ESKjw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCskFz1XO5iudh5kSwpNsrwA"",
            ""authorChannelId"": {
                    ""value"": ""UCskFz1XO5iudh5kSwpNsrwA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:41:02Z"",
            ""updatedAt"": ""2021-01-02T11:41:02Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""TOPT0brh6ajmyhd145c-hJaQQxI"",
      ""id"": ""UgwNk-TgN4_ekqUZGf14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""xTDCaKuddS4YuUFeMNvCxwFanq0"",
          ""id"": ""UgwNk-TgN4_ekqUZGf14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Только никто не говорит, как перенос производства повлиял на качество."",
            ""textOriginal"": ""Только никто не говорит, как перенос производства повлиял на качество."",
            ""authorDisplayName"": ""Омар Шайхалиев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngb332GN2Uic16ym4FffOsZMND2raSd1DWsRg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCQ0ajiCY8t3VOlpGi35L7BQ"",
            ""authorChannelId"": {
                    ""value"": ""UCQ0ajiCY8t3VOlpGi35L7BQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:40:05Z"",
            ""updatedAt"": ""2021-01-02T11:40:05Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""879QWnzPv2yr24b92srH8GQ-s84"",
      ""id"": ""UgzaIDDiKkl7qcywQHZ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ZQGDvc79ILWRnwvReFrdp-avgMw"",
          ""id"": ""UgzaIDDiKkl7qcywQHZ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""От истории с ветряком - мороз по спине. Не переоцениваю реакции своего организма, но что-то настоящее в этой истории проявляется. Денис, благодарю! С Наступившим"",
            ""textOriginal"": ""От истории с ветряком - мороз по спине. Не переоцениваю реакции своего организма, но что-то настоящее в этой истории проявляется. Денис, благодарю! С Наступившим"",
            ""authorDisplayName"": ""Дмитрий Поваляев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh8pejnHMmXAka5hv2HAQFT1CRa3ED2MLtK77kguA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCDvAyW1Wy04w8qKkuF6u6aA"",
            ""authorChannelId"": {
                    ""value"": ""UCDvAyW1Wy04w8qKkuF6u6aA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:39:17Z"",
            ""updatedAt"": ""2021-01-02T11:39:17Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""h1EWLjuGUtqLOYzBwnzmP31wH40"",
      ""id"": ""UgyKBj7BDqCC8mSCg9R4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""qPpigiCdtqi0-XVARcnhLNNkxvg"",
          ""id"": ""UgyKBj7BDqCC8mSCg9R4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Жду закрытые темы."",
            ""textOriginal"": ""Жду закрытые темы."",
            ""authorDisplayName"": ""Free Thinker"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniSHJLGbxOWWvpj1ftwgod7gb0qI9wIFwA6TQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCHfzfA1gEqvKLQmInnihSkQ"",
            ""authorChannelId"": {
                    ""value"": ""UCHfzfA1gEqvKLQmInnihSkQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T11:38:16Z"",
            ""updatedAt"": ""2021-01-02T11:38:16Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""vQKE-Nc3O_6pGTaMKR6SrbqYYzs"",
      ""id"": ""UgzPHuhTNxx2TfI0zOh4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""zjXRK83WTuLy0ZPjmkaPcYr_WOE"",
          ""id"": ""UgzPHuhTNxx2TfI0zOh4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Дрьриттуде сртоабетоатоп"",
            ""textOriginal"": ""Дрьриттуде сртоабетоатоп"",
            ""authorDisplayName"": ""Николай Бородкин"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnii_T7bFX0CAyfmqvdfZEewKUdA_6gVguoq5lgQFC0=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC9E-OWG4yUixcc1a7pS2aig"",
            ""authorChannelId"": {
                    ""value"": ""UC9E-OWG4yUixcc1a7pS2aig""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:37:33Z"",
            ""updatedAt"": ""2021-01-02T11:37:33Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""ydoJVwpD9GxwUUJvqEXSB_Pvb20"",
      ""id"": ""Ugxds7TA5fSGyV1S3kJ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""BJSebT1Z6dhonYC3FuGO0Z2ZZ4A"",
          ""id"": ""Ugxds7TA5fSGyV1S3kJ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Респект за 60фпс!"",
            ""textOriginal"": ""Респект за 60фпс!"",
            ""authorDisplayName"": ""Неопознанная панда"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjt3VXUdvenq1DbfR4O6S78S-pbuOZcv-SpLvJMsg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCZEM-0oDDDKazMhDH5evGdQ"",
            ""authorChannelId"": {
                    ""value"": ""UCZEM-0oDDDKazMhDH5evGdQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:34:48Z"",
            ""updatedAt"": ""2021-01-02T11:34:48Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""f0XiFZ83WQQDWCsEpi2GLckOLt0"",
      ""id"": ""Ugxhfa_wQ-xUGBtBmhJ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""cFJRD31NEl7FUQefa9sIOMfyhSM"",
          ""id"": ""Ugxhfa_wQ-xUGBtBmhJ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""после постера в начале 2020 года я подумал хорошо что щас уже 2021год)))"",
            ""textOriginal"": ""после постера в начале 2020 года я подумал хорошо что щас уже 2021год)))"",
            ""authorDisplayName"": ""Степан Головченко"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj34x-goPm90PkBNUC9lr32auVmVhGSIVEKlgHWuw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCzFZhM6hvaytYKJUcObCMDg"",
            ""authorChannelId"": {
                    ""value"": ""UCzFZhM6hvaytYKJUcObCMDg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 3,
            ""publishedAt"": ""2021-01-02T11:34:32Z"",
            ""updatedAt"": ""2021-01-02T11:34:32Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Ap13D_4V2-YlWNx96QRNL-st-jc"",
      ""id"": ""Ugz7LeSM2IZ8AzS7IoF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""fOHKgMK0ei-4TnwlZ0ZjDWnPYCw"",
          ""id"": ""Ugz7LeSM2IZ8AzS7IoF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Второй ракурс крупноват , а так качество улучшается !"",
            ""textOriginal"": ""Второй ракурс крупноват , а так качество улучшается !"",
            ""authorDisplayName"": ""Неопознанная панда"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjt3VXUdvenq1DbfR4O6S78S-pbuOZcv-SpLvJMsg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCZEM-0oDDDKazMhDH5evGdQ"",
            ""authorChannelId"": {
                    ""value"": ""UCZEM-0oDDDKazMhDH5evGdQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:33:42Z"",
            ""updatedAt"": ""2021-01-02T11:33:42Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""RWoBTQa17b9S_qennrMfyijTfvs"",
      ""id"": ""Ugw-wFjEmPkQ5A1NpsB4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""mqLtjRe81K-B9nns15sDQshYq48"",
          ""id"": ""Ugw-wFjEmPkQ5A1NpsB4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""С Новым годом 🎉🎄 🍾 Когда будут закрытые теми? А то уже соскучились )))"",
            ""textOriginal"": ""С Новым годом 🎉🎄 🍾 Когда будут закрытые теми? А то уже соскучились )))"",
            ""authorDisplayName"": ""Wikki Wins"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjLLNeuGB1RMINTZ5hcqj7k23IzqbSPENyOjFa-=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCER1cGHKiuCEg1kB65qxG6w"",
            ""authorChannelId"": {
                    ""value"": ""UCER1cGHKiuCEg1kB65qxG6w""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T11:32:42Z"",
            ""updatedAt"": ""2021-01-02T11:32:42Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""xPWlecFI-1o2MyZg9ogZFcAp9hY"",
      ""id"": ""UgxV6BXjsfTA559KQWR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""QDjBqbkhHPJqhYQRVTmzYZ-gyeY"",
          ""id"": ""UgxV6BXjsfTA559KQWR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""с Новым город! Денис, 1.что думаеш про Дэйла Карнеги? 2.когда стоит продавать биток? или вообще не продавать?"",
            ""textOriginal"": ""с Новым город! Денис, 1.что думаеш про Дэйла Карнеги? 2.когда стоит продавать биток? или вообще не продавать?"",
            ""authorDisplayName"": ""Screwy Piero"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniFKGby3P22H52hyrJC2NrB47f14dUQxp_PkU8A=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCErc9quppqzs0pLOA0kD0tw"",
            ""authorChannelId"": {
                    ""value"": ""UCErc9quppqzs0pLOA0kD0tw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:32:29Z"",
            ""updatedAt"": ""2021-01-02T11:32:29Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""qvEXKGPd6a9eIRddaVX4F5Au_a8"",
      ""id"": ""Ugx1IJje9McbE71pWlJ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""Xkn95NTpRWUxsuYdlEszh_-DhlU"",
          ""id"": ""Ugx1IJje9McbE71pWlJ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Почему нет запроса на White Lives Matter"",
            ""textOriginal"": ""Почему нет запроса на White Lives Matter"",
            ""authorDisplayName"": ""Омар Шайхалиев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngb332GN2Uic16ym4FffOsZMND2raSd1DWsRg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCQ0ajiCY8t3VOlpGi35L7BQ"",
            ""authorChannelId"": {
                    ""value"": ""UCQ0ajiCY8t3VOlpGi35L7BQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:31:48Z"",
            ""updatedAt"": ""2021-01-02T11:31:48Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""SNEed7_3nK3eN2AUssc1SQWgowA"",
      ""id"": ""Ugy3WTNE8bZ0T_1dLnl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""PuBXur06_cqVFI7P6Ec3IXtcQNY"",
          ""id"": ""Ugy3WTNE8bZ0T_1dLnl4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Пля думал это про деньги. 👎👎👎"",
            ""textOriginal"": ""Пля думал это про деньги. 👎👎👎"",
            ""authorDisplayName"": ""Илоф Макс"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjb2Z_KLKBsJC-vfZZvnobNjLXAHZV-IPV8wG7i=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCIaykLXjEHH0Zahu-TH9xdw"",
            ""authorChannelId"": {
                    ""value"": ""UCIaykLXjEHH0Zahu-TH9xdw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:30:02Z"",
            ""updatedAt"": ""2021-01-02T11:30:02Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""DQDbVuh76HLS7q9kbQ588B3S9LU"",
      ""id"": ""UgzwIl073GeY0p9t5np4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""UO4rZ3p34h3cTtnFshXgwSQpCwk"",
          ""id"": ""UgzwIl073GeY0p9t5np4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис,Анна и все подписчики,поздравляю вас с Новым годом и желаю вашим семьям здоровья и личностного роста😜"",
            ""textOriginal"": ""Денис,Анна и все подписчики,поздравляю вас с Новым годом и желаю вашим семьям здоровья и личностного роста😜"",
            ""authorDisplayName"": ""Асмодей Люциферович"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngeLrlRyqrMJkOnGEDp7JG8VZoe4gq4NZWHtqyf=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCFcLFgeRWN0LoJRBCtB_Xdw"",
            ""authorChannelId"": {
                    ""value"": ""UCFcLFgeRWN0LoJRBCtB_Xdw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:29:55Z"",
            ""updatedAt"": ""2021-01-02T11:29:55Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""oLSLtRB4YkDaJmmq8WUTeh6EPQM"",
      ""id"": ""UgzZEzzQiiqkAhBckit4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""pEvD02eJl32CZZO25ORhurVmt3o"",
          ""id"": ""UgzZEzzQiiqkAhBckit4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""То есть следить за собой и быть красивыми могут только женщины что ли? Если мужчина подтянутый, c привлекательной внешностью то это как бы получается само собой разумеется и типа поровну тут не работает?"",
            ""textOriginal"": ""То есть следить за собой и быть красивыми могут только женщины что ли? Если мужчина подтянутый, c привлекательной внешностью то это как бы получается само собой разумеется и типа поровну тут не работает?"",
            ""authorDisplayName"": ""Ivan Evdokimov"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngVT7jhaw-_qnmHe5lO7LQXDxTeIm1NVYdPFxUrxA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCBVMPL1QB2b_CflUSP_AAOg"",
            ""authorChannelId"": {
                    ""value"": ""UCBVMPL1QB2b_CflUSP_AAOg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:28:55Z"",
            ""updatedAt"": ""2021-01-02T11:28:55Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""jdgQZH2PfMn4tcgLJXScB1u_03w"",
      ""id"": ""UgySUSNhg_vpPd9WyWx4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""X-pFIZJkUSsdcoIngcQtAC00uOE"",
          ""id"": ""UgySUSNhg_vpPd9WyWx4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Мне кажется, и мужчина и женщина должны направиться друг другу физически, именно тогда просыпается настоящая страсть. И для здоровья полезно)"",
            ""textOriginal"": ""Мне кажется, и мужчина и женщина должны направиться друг другу физически, именно тогда просыпается настоящая страсть. И для здоровья полезно)"",
            ""authorDisplayName"": ""George Valentine"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwni0_AqPl10LIBjFSlFsGpju3DJUYViRRs0t8NpZog=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCiLCh7cmEUnZKdnAxO_5jrQ"",
            ""authorChannelId"": {
                    ""value"": ""UCiLCh7cmEUnZKdnAxO_5jrQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:26:00Z"",
            ""updatedAt"": ""2021-01-02T11:26:00Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""lM7To0xfspqyxyTWph04tBQriCo"",
      ""id"": ""Ugw4IxnLfQAMPjlvprN4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""m2DEz25U8apSddQBZVtulk-aaSE"",
          ""id"": ""Ugw4IxnLfQAMPjlvprN4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Очень крутой сюжет. Идеи наивысшие!! Спасибо!!! На моменте проигрыша &quot;основания&quot; что-то цыкает в левой колонке, звук какой-то непонятный"",
            ""textOriginal"": ""Очень крутой сюжет. Идеи наивысшие!! Спасибо!!! На моменте проигрыша \""основания\"" что-то цыкает в левой колонке, звук какой-то непонятный"",
            ""authorDisplayName"": ""AdamThomasMoran !"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhL9iE7aPxcsPRU43JkgKhPptKgqy9xw7mfag=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC_snTLhsoZyg3IgpW3z-Y-Q"",
            ""authorChannelId"": {
                    ""value"": ""UC_snTLhsoZyg3IgpW3z-Y-Q""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T11:23:06Z"",
            ""updatedAt"": ""2021-01-02T11:23:06Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""iJKmETME5QHO6QWiOYZaV6c3Fxc"",
      ""id"": ""UgxJgiKm_QGiWdL2YYp4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""Y2ks2tutbE3_-CTK2UP2QyZf-uQ"",
          ""id"": ""UgxJgiKm_QGiWdL2YYp4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Всем привет!!!  Денис вовремя!!! Видос выпустил!!!"",
            ""textOriginal"": ""Всем привет!!!  Денис вовремя!!! Видос выпустил!!!"",
            ""authorDisplayName"": ""Вячеслав Попов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjvk1VQDtS_xkMLt-J3MB3VwBr2vvTSmnHixQlGBA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCP_55OSp3_I3sA3QZXzqHSg"",
            ""authorChannelId"": {
                    ""value"": ""UCP_55OSp3_I3sA3QZXzqHSg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:22:18Z"",
            ""updatedAt"": ""2021-01-02T11:22:18Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""b9uUF9YOpHcQ1K63P7pQVlYKjjc"",
      ""id"": ""Ugz7TRbBpIgmloDsUn94AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""SwQqeGHQ4Zl8m9g9RZy859tBlkw"",
          ""id"": ""Ugz7TRbBpIgmloDsUn94AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Критерии красоты объективны, они прописаны эволюцией."",
            ""textOriginal"": ""Критерии красоты объективны, они прописаны эволюцией."",
            ""authorDisplayName"": ""Омар Шайхалиев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngb332GN2Uic16ym4FffOsZMND2raSd1DWsRg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCQ0ajiCY8t3VOlpGi35L7BQ"",
            ""authorChannelId"": {
                    ""value"": ""UCQ0ajiCY8t3VOlpGi35L7BQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:20:37Z"",
            ""updatedAt"": ""2021-01-02T11:20:37Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""DFA8Qln0nTT-bEeD2z1bHLbfw_E"",
      ""id"": ""UgwUiVkDAMoJau3Q-KF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""Amt8nPLZFCJVmhFRRednl6FIoHk"",
          ""id"": ""UgwUiVkDAMoJau3Q-KF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Это деградация нашей цивилизации."",
            ""textOriginal"": ""Это деградация нашей цивилизации."",
            ""authorDisplayName"": ""Омар Шайхалиев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngb332GN2Uic16ym4FffOsZMND2raSd1DWsRg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCQ0ajiCY8t3VOlpGi35L7BQ"",
            ""authorChannelId"": {
                    ""value"": ""UCQ0ajiCY8t3VOlpGi35L7BQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:19:00Z"",
            ""updatedAt"": ""2021-01-02T11:19:00Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""FBPbkfixVYP2E5YkeWESo4fxkIg"",
      ""id"": ""Ugzs3pjkemkYBkQhDSx4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""aimohMLwHBE0C3Oytf-fWbFUfo4"",
          ""id"": ""Ugzs3pjkemkYBkQhDSx4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Слабоватый выпуск. Лучше пореже но по интересней  темы и по насыщенней)"",
            ""textOriginal"": ""Слабоватый выпуск. Лучше пореже но по интересней  темы и по насыщенней)"",
            ""authorDisplayName"": ""Михаил"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhBFXNLV8zzrvb6n_02Q-qFhGVnZteBVPrj8w=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCIAR_rsEIRrIE56r6IznMaw"",
            ""authorChannelId"": {
                    ""value"": ""UCIAR_rsEIRrIE56r6IznMaw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:18:14Z"",
            ""updatedAt"": ""2021-01-02T11:18:14Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""7vQoRElFq7XwJZODyDGSLboUMro"",
      ""id"": ""UgzUvQdyMjrnaUB14v54AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""lPIfwkUvlph0hoSXsJn7Z8ZGFtk"",
          ""id"": ""UgzUvQdyMjrnaUB14v54AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Рад, что Борисыч поднял тему современного sjw-движа, а то всё обходили стороной"",
            ""textOriginal"": ""Рад, что Борисыч поднял тему современного sjw-движа, а то всё обходили стороной"",
            ""authorDisplayName"": ""The Plot"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniP1KGzQ4_dJ2OYMFEx5D-OccQ7s3la6Wg_6tkv=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCdzT8C05dMOUNxFsGNATBsw"",
            ""authorChannelId"": {
                    ""value"": ""UCdzT8C05dMOUNxFsGNATBsw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:11:36Z"",
            ""updatedAt"": ""2021-01-02T11:11:36Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""9wcd7bCDITuYjzqtffjiHRasVqQ"",
      ""id"": ""Ugzjfzv4rUYIKo1Ywvt4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""n_P5tUbGwP19XMt2bEft2G9woQ4"",
          ""id"": ""Ugzjfzv4rUYIKo1Ywvt4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Я думаю коммунизм это наше будущее, народ сам к этому придет, но тогда, когда достигнет определенный уровень развития и склад ума и это будет добровольно"",
            ""textOriginal"": ""Я думаю коммунизм это наше будущее, народ сам к этому придет, но тогда, когда достигнет определенный уровень развития и склад ума и это будет добровольно"",
            ""authorDisplayName"": ""Andrejs M"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnipxDLgzYxiWKzi5PY6Eowiqe_S8ou7NX4qVw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCDqSpXbNxz8GyKVHY2U3yug"",
            ""authorChannelId"": {
                    ""value"": ""UCDqSpXbNxz8GyKVHY2U3yug""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:10:54Z"",
            ""updatedAt"": ""2021-01-02T11:11:51Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""uapKEXxyaHZlS2H-hWKp4GJ3ILA"",
      ""id"": ""UgwHdOur9pViABSCkp54AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""1AoXvM36VIfQyM8gXl1Y5QjQfvk"",
          ""id"": ""UgwHdOur9pViABSCkp54AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Спасибо, Денис, за поздравления! Я тебе тоже желаю процветания, достижения целей, и поздравляю с рождением ребёнка! Да прибудет с тобой сила, Ден!💪😁"",
            ""textOriginal"": ""Спасибо, Денис, за поздравления! Я тебе тоже желаю процветания, достижения целей, и поздравляю с рождением ребёнка! Да прибудет с тобой сила, Ден!💪😁"",
            ""authorDisplayName"": ""Chikeko Lee"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh0OyfdBQa5ShW8NFLKd91FlVfIFdzGxlC-KG7eMA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCU8C_D3TtPfHcQ4KeWAe26w"",
            ""authorChannelId"": {
                    ""value"": ""UCU8C_D3TtPfHcQ4KeWAe26w""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:09:58Z"",
            ""updatedAt"": ""2021-01-02T11:09:58Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""AVfMQd1QBXD3bRRjLKUnbQMBPok"",
      ""id"": ""UgzpdmFOsZW3VnsrKrV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ckomL9kWfBE3vKOQ2TMdeE-2cX0"",
          ""id"": ""UgzpdmFOsZW3VnsrKrV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денчик, а регулирование в Детройте не будет похоже на ситуацию в Беларуси, когда государство субсидирует убыточные предприятия. А не начнется ли в Беларуси беда, как в Детройте если начнут закрывать убыточные предприятия?"",
            ""textOriginal"": ""Денчик, а регулирование в Детройте не будет похоже на ситуацию в Беларуси, когда государство субсидирует убыточные предприятия. А не начнется ли в Беларуси беда, как в Детройте если начнут закрывать убыточные предприятия?"",
            ""authorDisplayName"": ""Andrejs M"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnipxDLgzYxiWKzi5PY6Eowiqe_S8ou7NX4qVw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCDqSpXbNxz8GyKVHY2U3yug"",
            ""authorChannelId"": {
                    ""value"": ""UCDqSpXbNxz8GyKVHY2U3yug""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T11:07:10Z"",
            ""updatedAt"": ""2021-01-02T11:07:10Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Qp0B6eFHAXksbVErQ4X9gjFqt5U"",
      ""id"": ""UgytfYpkKCNjZrWk_4F4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""bOOC0nGDjEdxsTp58dJ5TjbNv2w"",
          ""id"": ""UgytfYpkKCNjZrWk_4F4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Спасибо, очень интересно. Август Ландмессер (который не зигует) тоже показательный пример человеческих ценностей."",
            ""textOriginal"": ""Спасибо, очень интересно. Август Ландмессер (который не зигует) тоже показательный пример человеческих ценностей."",
            ""authorDisplayName"": ""Maxim Madulin"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjvImTAis2pKeVvoa1uYMrNkYz7sfpS7iCm7g=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC9XdmRr8YB17wH6Fv51mbqg"",
            ""authorChannelId"": {
                    ""value"": ""UC9XdmRr8YB17wH6Fv51mbqg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T11:00:23Z"",
            ""updatedAt"": ""2021-01-02T11:00:23Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""v9-r2IQ1xY8NWeD3ys5mWzIc9_I"",
      ""id"": ""UgyVxNq8-JRXjESOFDZ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ksk5ZqrgK4-FZWygx9Ax95y_DGY"",
          ""id"": ""UgyVxNq8-JRXjESOFDZ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""С НОВЫМ ГОДОМ! 🎅🎁🌲"",
            ""textOriginal"": ""С НОВЫМ ГОДОМ! 🎅🎁🌲"",
            ""authorDisplayName"": ""Александр Приходько"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhIwqAf_x5pw_E-i_PAAWCW-DC86ICaBT8rW5-aXg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCEc63o3uejH9A8_D2SaARmQ"",
            ""authorChannelId"": {
                    ""value"": ""UCEc63o3uejH9A8_D2SaARmQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:58:53Z"",
            ""updatedAt"": ""2021-01-02T10:58:53Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""0b3Huhjj3kq0bOI8iUMHiGl93XY"",
      ""id"": ""UgzmY12HFCZis41SFOh4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""zFa9R4_je8lHvqkDrSW247bTQTg"",
          ""id"": ""UgzmY12HFCZis41SFOh4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Хитрый хитрый Дэн. Тактично умолчал, насчет того, ел бы ли он человечину в подобных условиях. Но и так понятно, что ел бы еще и  причмокивая. Знаю, что он прочитает коммент, но не лайкнет, потому что палево)"",
            ""textOriginal"": ""Хитрый хитрый Дэн. Тактично умолчал, насчет того, ел бы ли он человечину в подобных условиях. Но и так понятно, что ел бы еще и  причмокивая. Знаю, что он прочитает коммент, но не лайкнет, потому что палево)"",
            ""authorDisplayName"": ""Вася Пупкин"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniXVVch8cvGFy4OuM-7zKgnj5ZO3uXHBgeb_BHUKw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC1W0oACdtWAQf_MXqZeKXVA"",
            ""authorChannelId"": {
                    ""value"": ""UC1W0oACdtWAQf_MXqZeKXVA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:48:58Z"",
            ""updatedAt"": ""2021-01-02T10:48:58Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""ZtlX_f2r0Lyy6i3SZ02BQPLMmsk"",
      ""id"": ""UgzS6FhUu8mwPOItyap4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""hckIK6eQl_T4eupzNJFOBtP3R5A"",
          ""id"": ""UgzS6FhUu8mwPOItyap4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Отлайкайте комментарий. Пусть Юрий Дудь возьмёт интервью у Дэнчика 😏\u003cbr /\u003eБыло бы интересно, на мой взгляд"",
            ""textOriginal"": ""Отлайкайте комментарий. Пусть Юрий Дудь возьмёт интервью у Дэнчика 😏\nБыло бы интересно, на мой взгляд"",
            ""authorDisplayName"": ""Игорь Андреев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh2rczJScG_8yD6-hBnbJY-cW8asFXPMcsY5byREw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC_kVJ46ghf1zB737iuzQXfw"",
            ""authorChannelId"": {
                    ""value"": ""UC_kVJ46ghf1zB737iuzQXfw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T10:47:41Z"",
            ""updatedAt"": ""2021-01-02T10:47:41Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 2,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""zDt_JoL7UbSXkZo2obNU9XW1vGY"",
      ""id"": ""UgxdvaU3saWE4-nmGnR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""L0tWvffnoV4Z0XTMWzWCxzNDmGk"",
          ""id"": ""UgxdvaU3saWE4-nmGnR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Ну на счет других звездных систем, ты малость перегнул конечно, Денис. Не, лететь туда конечно можно, лет 10, миллионов, наверное.)) Нет, я полностью за, так как в радиусе 100 световых лет от Земли, на данный момент, обнаружили вроде бы около 20 пригодных для жизни планет, но к сожалению попасть туда нет никакой возможности, потому что это овердалеко, к сожалению!!! Но проблему эту каким-то образом решать придется, потому что на нашем родном (тут без иронии, мы все живы благодаря ему) Солнышке постоянно растет количество Гелия и оно постоянно разогревается, растет в размерах и делается все менее стабильным. И по самым оптимистическим прогнозам людям осталось примерно 100 миллионов лет, дальше нам здесь жить будет физически не возможно, далее, примерно через 500 млн. лет, пропадут все высшие организмы, и через миллиард лет подохнут даже бактерии. Яркий пример тому - Венера, когда-то давно это была планета с комфортными условиями для жизни, а сейчас это аналог ада, с температурой 400 градусов на поверхности, давлением в 90 атмосфер и кислотными дождями, вот нашу планетку ждет примерно тоже самое))).  Я понимаю, что сейчас тема космоса очень распиаренная, Илон Маск, Роскосмос, Китай... На самом  деле космические технологии очень примитивные, и позволяют  забрасывать грузы, за приемлемое время, максимум до ближайших планет."",
            ""textOriginal"": ""Ну на счет других звездных систем, ты малость перегнул конечно, Денис. Не, лететь туда конечно можно, лет 10, миллионов, наверное.)) Нет, я полностью за, так как в радиусе 100 световых лет от Земли, на данный момент, обнаружили вроде бы около 20 пригодных для жизни планет, но к сожалению попасть туда нет никакой возможности, потому что это овердалеко, к сожалению!!! Но проблему эту каким-то образом решать придется, потому что на нашем родном (тут без иронии, мы все живы благодаря ему) Солнышке постоянно растет количество Гелия и оно постоянно разогревается, растет в размерах и делается все менее стабильным. И по самым оптимистическим прогнозам людям осталось примерно 100 миллионов лет, дальше нам здесь жить будет физически не возможно, далее, примерно через 500 млн. лет, пропадут все высшие организмы, и через миллиард лет подохнут даже бактерии. Яркий пример тому - Венера, когда-то давно это была планета с комфортными условиями для жизни, а сейчас это аналог ада, с температурой 400 градусов на поверхности, давлением в 90 атмосфер и кислотными дождями, вот нашу планетку ждет примерно тоже самое))).  Я понимаю, что сейчас тема космоса очень распиаренная, Илон Маск, Роскосмос, Китай... На самом  деле космические технологии очень примитивные, и позволяют  забрасывать грузы, за приемлемое время, максимум до ближайших планет."",
            ""authorDisplayName"": ""Juci Stetim"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwng6N7XxizXZSw3vWNAQRk0LxuQg8aB3N4xzFXEUKA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCxrUcyw-S79DOby4j_MjJWg"",
            ""authorChannelId"": {
                    ""value"": ""UCxrUcyw-S79DOby4j_MjJWg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T10:46:24Z"",
            ""updatedAt"": ""2021-01-02T10:46:24Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Ifrq3sFtrdVpbvRBzPUD76K78Zo"",
      ""id"": ""UgzOkP_55TxVElCNPSV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""30_qCXhxTR1tkNcKzDTj9c65bn4"",
          ""id"": ""UgzOkP_55TxVElCNPSV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""С Новым годом, Дэнчик! Здоровья, достатка и новых интересных проектов! А мы тебя и подпишем и отлайкаем!))) Спасибо за контент! Быть Добру!!!"",
            ""textOriginal"": ""С Новым годом, Дэнчик! Здоровья, достатка и новых интересных проектов! А мы тебя и подпишем и отлайкаем!))) Спасибо за контент! Быть Добру!!!"",
            ""authorDisplayName"": ""Music Savin"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjHI2T04dx_A-Q0rP88EB19-_fnxdNDrwIZQcEmhQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCbV6Ma6GLicmunAHeRBR7GQ"",
            ""authorChannelId"": {
                    ""value"": ""UCbV6Ma6GLicmunAHeRBR7GQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:43:24Z"",
            ""updatedAt"": ""2021-01-02T10:43:24Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""vvBt3zqju9T_92Q73f_ZAH-1T_8"",
      ""id"": ""Ugy-dz-cTaJCO1iAkIF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""nkCAIy3x51zVTZjW7TYtzmGnunY"",
          ""id"": ""Ugy-dz-cTaJCO1iAkIF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Государство сможет существовать без наркотиков (а особенно без легализованых нынче табака и алкоголя) ???"",
            ""textOriginal"": ""Государство сможет существовать без наркотиков (а особенно без легализованых нынче табака и алкоголя) ???"",
            ""authorDisplayName"": ""Harald Finehair"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngolZDr8iYNFG94wNoI7GbjXY8z7-BrniJkf1FKUw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UClra_BmCAPK--7Xs8-AhCKg"",
            ""authorChannelId"": {
                    ""value"": ""UClra_BmCAPK--7Xs8-AhCKg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:40:29Z"",
            ""updatedAt"": ""2021-01-02T10:40:54Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Nw5lL3IVk6UFCz1AhetFglYLbD8"",
      ""id"": ""UgwBVhCiatxpN1gjLyR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""wWooGTJfXvelfEvp0oJkgUwcqlA"",
          ""id"": ""UgwBVhCiatxpN1gjLyR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""комментарий чтобы продвинуть это видео"",
            ""textOriginal"": ""комментарий чтобы продвинуть это видео"",
            ""authorDisplayName"": ""CRYPTO LIFE"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh21w2jY6X5ZLNoP12BCxS-FIPxNTw7NW5BBq10=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCL3OvNNHZEYIfFuxe_3nUTQ"",
            ""authorChannelId"": {
                    ""value"": ""UCL3OvNNHZEYIfFuxe_3nUTQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:39:28Z"",
            ""updatedAt"": ""2021-01-02T10:39:28Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""eYmP6I4LQk2Rmu3MfKDHR-a3Trk"",
      ""id"": ""UgyYZNaiw91GrycdUjV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""H6vqB7P4ieA6DuIia1aKaCkHWos"",
          ""id"": ""UgyYZNaiw91GrycdUjV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, теперь вместо еженедельных субботних выпусков про финансы будут саги ?\u003cbr /\u003eИ как повлияла дочка на домашний быт и съемку новых выпусков ?"",
            ""textOriginal"": ""Денис, теперь вместо еженедельных субботних выпусков про финансы будут саги ?\nИ как повлияла дочка на домашний быт и съемку новых выпусков ?"",
            ""authorDisplayName"": ""Oleg Gli"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhLxWP2-8D6yW30p8PTIDzdxY69sAScKBhcJujxRA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCBjz56Dlp6YPiOo3oa03uIQ"",
            ""authorChannelId"": {
                    ""value"": ""UCBjz56Dlp6YPiOo3oa03uIQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T10:37:06Z"",
            ""updatedAt"": ""2021-01-02T10:37:06Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
}
  ]
}
";
        public static string GetVideoCommentsFIrstPageNextPageToken = "QURTSl9pMFE0YmF6TzRaR1JIQmtKRndNcGRPekJ1TW5oVE5SLXk1S0wxNE4yZkt1UGctR1BlR016NUYyVFQtczBLQnB1V1VHYzNGN3g1VTZKaG9OdHVqeVVOUm1JWHZhYWc=";
        public static string GetVideoCommentsLastPage { get; set; } = @"{
  ""kind"": ""youtube#commentThreadListResponse"",
  ""etag"": ""T9RH0NVIJ0uyrziBJ2JnUsV5JRU"",
  ""previousPageToken"": ""QURTSl9pMnZ5NzZ3Q014UHRpSG8wUXV6eXlpdXlYdU1TUUpObkpCczhPNGFWWWdrOW80QjRRcjJaN01EZzlHaWR0VmdjOEQ5YTJpcnkyREJsbWNoVUcwbW9ha2QxRm4zMUE="",
  ""pageInfo"": {
    ""totalResults"": 100,
    ""resultsPerPage"": 100
  },
  ""items"": [
    {
      ""kind"": ""youtube#commentThread"",
      ""etag"": ""vfFtHB1vHnAQmNJGzJOFr1fNCtA"",
      ""id"": ""Ugw8eamhszGPJvNADIl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
          ""kind"": ""youtube#comment"",
          ""etag"": ""QXLYTzS3_InLdR-bf9m9u9jaG6E"",
          ""id"": ""Ugw8eamhszGPJvNADIl4AaABAg"",
          ""snippet"": {
            ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, по поводу первого сюжета. Не все так просто) Все еще хуже, это мужик. Эту модель звать Jari Jones. Это не девушка, это трансгендер..."",
            ""textOriginal"": ""Денис, по поводу первого сюжета. Не все так просто) Все еще хуже, это мужик. Эту модель звать Jari Jones. Это не девушка, это трансгендер..."",
            ""authorDisplayName"": ""BOCKPEC"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjuQe7YlmvBjWbVQg7e6FU6XtT0N4xtEJ-ZjqE=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCaemKSiuTxE4RVcw4uL9JeQ"",
            ""authorChannelId"": {
              ""value"": ""UCaemKSiuTxE4RVcw4uL9JeQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:29:01Z"",
            ""updatedAt"": ""2021-01-02T10:29:01Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
    },
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""fGHGDSucYo7ZoutfF02zN-_ZtP8"",
      ""id"": ""Ugx-jcf6YdW518ck5vJ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""tDrTLuxNx0fBcD3J5p34kV3wyk0"",
          ""id"": ""Ugx-jcf6YdW518ck5vJ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис айда в президенты я за тебя проголосую"",
            ""textOriginal"": ""Денис айда в президенты я за тебя проголосую"",
            ""authorDisplayName"": ""Антон Воскресенский"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwng35xkP9B1wKOCIvo2le3EK_d7KogoPUlV-vA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCpg-NCaUgKK09oQ3RoHI7Fg"",
            ""authorChannelId"": {
                    ""value"": ""UCpg-NCaUgKK09oQ3RoHI7Fg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:27:36Z"",
            ""updatedAt"": ""2021-01-02T10:27:36Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""QbmsOsCexjAioFUtAnOEu41li5c"",
      ""id"": ""UgyDJuz3bvPdkSOeis94AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""X0L0FtU1X7JoKCROGEOc-fkaw1U"",
          ""id"": ""UgyDJuz3bvPdkSOeis94AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Все как всегда отлично и интересно Денис,но вот на счет МД-движения ты немного не прав.Суть этого движения заключается в том что бы пробудить в мужчинах мужчин,которых они порой забывают под воздействием всей этой пропаганды аленизма и массовой озабоченности сильного пола ,от чего у женщин стало больше возможностей дабы развести этот пресловутый сильный пол.Это не та феминстская лабуда о равноправии,это своего рода концепция поведения мужчин разумных,дабы сохранить свой тестостерон,который и строить и жить помогает.Я например благодаря МД понял для себя что значит разумное воздержание,что значит ставить себя перед женщинами и как ставить ее в &quot;позу&quot; нужную мне.А ведь многие лебезят перед девушками,что изначально их ставит в невыгодное положение,от чего и проистекают остальные проблемы.С новым годом ребята и да прибудет с нами тишина и сила!😉"",
            ""textOriginal"": ""Все как всегда отлично и интересно Денис,но вот на счет МД-движения ты немного не прав.Суть этого движения заключается в том что бы пробудить в мужчинах мужчин,которых они порой забывают под воздействием всей этой пропаганды аленизма и массовой озабоченности сильного пола ,от чего у женщин стало больше возможностей дабы развести этот пресловутый сильный пол.Это не та феминстская лабуда о равноправии,это своего рода концепция поведения мужчин разумных,дабы сохранить свой тестостерон,который и строить и жить помогает.Я например благодаря МД понял для себя что значит разумное воздержание,что значит ставить себя перед женщинами и как ставить ее в \""позу\"" нужную мне.А ведь многие лебезят перед девушками,что изначально их ставит в невыгодное положение,от чего и проистекают остальные проблемы.С новым годом ребята и да прибудет с нами тишина и сила!😉"",
            ""authorDisplayName"": ""Алексей Кузьмин"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjTfKUokmeFOKeR7dL0d0TTWpTZ8os1gq9ZgQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCc0F10-ORw7wy04n4iyAa9g"",
            ""authorChannelId"": {
                    ""value"": ""UCc0F10-ORw7wy04n4iyAa9g""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:19:41Z"",
            ""updatedAt"": ""2021-01-02T10:19:41Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""JBgPiWLENJIq_-N_m0mqzKnavu0"",
      ""id"": ""UgxQIQe7HDUTXH_1XJZ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""bjW_DsAnubWzFu-hg0LP2lLAXK4"",
          ""id"": ""UgxQIQe7HDUTXH_1XJZ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""денчик ты че нас с нг не поздравил аа?!?)))))))"",
            ""textOriginal"": ""денчик ты че нас с нг не поздравил аа?!?)))))))"",
            ""authorDisplayName"": ""WALLY Кузьмин"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjiyl-230pF9NzDJWj18tDDjbtnEVqRiFgK_Tk=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCVUoMWqe9T-GeEoO7G8TEWQ"",
            ""authorChannelId"": {
                    ""value"": ""UCVUoMWqe9T-GeEoO7G8TEWQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:13:33Z"",
            ""updatedAt"": ""2021-01-02T10:13:33Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""6P8mJ9OdwGscX8biBJezKUwBKX4"",
      ""id"": ""UgyQLa0OQalj1u-3WSl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""PlWe1i-n4zZWKkUg7uta0jM7kr4"",
          ""id"": ""UgyQLa0OQalj1u-3WSl4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Представь, если в обществе тебе даётся определенная сумма средств в день, которой достаточно для удовлетворения базовых потребностей в еде, но к концу дня оно сгорает. Это может искоренить абсолютную нищету, а тем кто хочет больше, то можно зарабатывать отдельный вид денег, которые не сгорают. Как ты думаешь, такая система толкнёт нас вперёд?"",
            ""textOriginal"": ""Представь, если в обществе тебе даётся определенная сумма средств в день, которой достаточно для удовлетворения базовых потребностей в еде, но к концу дня оно сгорает. Это может искоренить абсолютную нищету, а тем кто хочет больше, то можно зарабатывать отдельный вид денег, которые не сгорают. Как ты думаешь, такая система толкнёт нас вперёд?"",
            ""authorDisplayName"": ""Василиск Роко"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjYePOri_y4AsXhM4RNKVU4jV0KiUX26jy2WTKSEw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCoiVeB4azyAh7ZjmgIkHeGQ"",
            ""authorChannelId"": {
                    ""value"": ""UCoiVeB4azyAh7ZjmgIkHeGQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:12:14Z"",
            ""updatedAt"": ""2021-01-02T10:12:14Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""PUiLLPW_ZxanZIrIOobNVcaIP3A"",
      ""id"": ""UgxdVlLU-jVsuj3qpA14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""wTmrZxKzE3L9CR_1asBTN1d-M_g"",
          ""id"": ""UgxdVlLU-jVsuj3qpA14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""и еще такое слышал особенно когда мать болела раком молочной железы, другие женщины говорили зачем они нам нужны мы их используем только раз или несколько раз лиш бы выкормить ребенка год максимум пару лет остальное время висят могут приносить опасные проблемы"",
            ""textOriginal"": ""и еще такое слышал особенно когда мать болела раком молочной железы, другие женщины говорили зачем они нам нужны мы их используем только раз или несколько раз лиш бы выкормить ребенка год максимум пару лет остальное время висят могут приносить опасные проблемы"",
            ""authorDisplayName"": ""виктор супруненко"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngQ3iHfkF5gMUmjMzmdV1XntX6iXzjeHnMybQEJNg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCVQPg8XCIk8xB3N7XrKDxGA"",
            ""authorChannelId"": {
                    ""value"": ""UCVQPg8XCIk8xB3N7XrKDxGA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:11:37Z"",
            ""updatedAt"": ""2021-01-02T10:11:37Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""ve16w8I_aqBXicL24kexnmlYF6Y"",
      ""id"": ""Ugzivlboc5-TN_E-cS14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""zj712a08_8V6q5jOnMS4OJiCl-s"",
          ""id"": ""Ugzivlboc5-TN_E-cS14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Дэнчик, судя по блоку «все возможно», ты можешь взять обратно свои слова, про «проект Венера» и допустить такое общество при наличии убеждений?) С Новым годом, брат! Сила с нами 💪🏻"",
            ""textOriginal"": ""Дэнчик, судя по блоку «все возможно», ты можешь взять обратно свои слова, про «проект Венера» и допустить такое общество при наличии убеждений?) С Новым годом, брат! Сила с нами 💪🏻"",
            ""authorDisplayName"": ""Василиск Роко"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjYePOri_y4AsXhM4RNKVU4jV0KiUX26jy2WTKSEw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCoiVeB4azyAh7ZjmgIkHeGQ"",
            ""authorChannelId"": {
                    ""value"": ""UCoiVeB4azyAh7ZjmgIkHeGQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:01:06Z"",
            ""updatedAt"": ""2021-01-02T10:01:06Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 4,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""-ir_jdICIkHJTeeWiMA8wqnpGG8"",
      ""id"": ""UgzDV82uw18JUlDMICd4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ezspaX90YvP5neDHs985TIaUBPU"",
          ""id"": ""UgzDV82uw18JUlDMICd4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Сначало подумал это Денчик на превью)"",
            ""textOriginal"": ""Сначало подумал это Денчик на превью)"",
            ""authorDisplayName"": ""Radomir mighty"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniAHs7TOky51N-9AkVFYfzkmp39ynDijDoKtg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCfJUtjQuCNEqpILxNkeJMRQ"",
            ""authorChannelId"": {
                    ""value"": ""UCfJUtjQuCNEqpILxNkeJMRQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T10:00:07Z"",
            ""updatedAt"": ""2021-01-02T10:00:07Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""zrERlUsO3iJc5-93iZ5rt0VGSkA"",
      ""id"": ""UgwS0_OE6Ra9Xg2ZmkF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""dPA0J_rckUFcwby7i6nneNVOJiM"",
          ""id"": ""UgwS0_OE6Ra9Xg2ZmkF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Дэнчик прокомментируй фильм &quot; капитал в 21 веке&quot; , если смотрел"",
            ""textOriginal"": ""Дэнчик прокомментируй фильм \"" капитал в 21 веке\"" , если смотрел"",
            ""authorDisplayName"": ""Тодари Георгий"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh--USJ_6tvVTOOpZzG7Ql5JGbOQrTbV2hbSlv0=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCCJotL_c8iTTME8FVBdPhQg"",
            ""authorChannelId"": {
                    ""value"": ""UCCJotL_c8iTTME8FVBdPhQg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:58:50Z"",
            ""updatedAt"": ""2021-01-02T09:58:50Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""_C30gTX6vUHE7ZTEVQF7yxwh-Qg"",
      ""id"": ""UgzSijSUpZr_9pH8OYB4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""lRSRnoq2tMFL9QrOPbgvEIVL96k"",
          ""id"": ""UgzSijSUpZr_9pH8OYB4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Поровну нельзя,у всех своя мера и дозировка"",
            ""textOriginal"": ""Поровну нельзя,у всех своя мера и дозировка"",
            ""authorDisplayName"": ""p1nkgu1tar"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjCgfOUy78TlGJPw4pyDs5xj89hxpVaTnqGwKsL=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCai0_KTDHAsBHNegGig_OXQ"",
            ""authorChannelId"": {
                    ""value"": ""UCai0_KTDHAsBHNegGig_OXQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:58:17Z"",
            ""updatedAt"": ""2021-01-02T09:58:17Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""5x5qPUomDBCaJANI3bK6TZ13A9Y"",
      ""id"": ""UgwAzW7qbR7C2YAJUsR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""L0OjWi4ey12Ut2UjwAqF6yUxEjI"",
          ""id"": ""UgwAzW7qbR7C2YAJUsR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""А мне пышки очень нравятся, между пышкой и худышкой/фитоняшей выберу пышку)"",
            ""textOriginal"": ""А мне пышки очень нравятся, между пышкой и худышкой/фитоняшей выберу пышку)"",
            ""authorDisplayName"": ""ram4ram"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhnBYSpmnbdxyOerR3Hken2RiXsnYTAchgC3A=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCop5W48leHfBG-w9dgh699w"",
            ""authorChannelId"": {
                    ""value"": ""UCop5W48leHfBG-w9dgh699w""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:56:57Z"",
            ""updatedAt"": ""2021-01-02T09:56:57Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""O13eeV0BMEEcSlAmhfCyoAgsusQ"",
      ""id"": ""Ugw-KmkpEFWf9EzNPcl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""kUSsJnz0RE_vSpWd-AGiKNGsr78"",
          ""id"": ""Ugw-KmkpEFWf9EzNPcl4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Спасибо Денис и вас с Новым годом!"",
            ""textOriginal"": ""Спасибо Денис и вас с Новым годом!"",
            ""authorDisplayName"": ""Nuni Bertleuov"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhvFCi4d3Pq3W4901dviGV5yyCuOiob-nz2f1Pfbg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCnjFCdPgqY7efCCWrVpChxQ"",
            ""authorChannelId"": {
                    ""value"": ""UCnjFCdPgqY7efCCWrVpChxQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:53:24Z"",
            ""updatedAt"": ""2021-01-02T09:53:24Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""MU4mXx-lzm04JEomg6c9xFffQk4"",
      ""id"": ""UgwwdFWB7VXDB3pOTxd4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ULaMIGqk_p8EkKYuZx5mPyKyZ30"",
          ""id"": ""UgwwdFWB7VXDB3pOTxd4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Спасибо, с Новым годом! СПАСИБО ВАМ!"",
            ""textOriginal"": ""Спасибо, с Новым годом! СПАСИБО ВАМ!"",
            ""authorDisplayName"": ""Дмитрий Голышев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjWS4WJBj3NZ3saiAjgTwqA8mT5OurkgxJQxnwNKg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC5dGgGwhxtBIEOl2AE_uMtg"",
            ""authorChannelId"": {
                    ""value"": ""UC5dGgGwhxtBIEOl2AE_uMtg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:48:55Z"",
            ""updatedAt"": ""2021-01-02T09:48:55Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""ue2uk3jeH1vDiWjwqNYRU8ez9Z4"",
      ""id"": ""Ugz2qbop-ki70mxdSvZ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""jmSjtb2rE38Ph_5KqiypIpWl_YI"",
          ""id"": ""Ugz2qbop-ki70mxdSvZ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Такой формат мне больше нравится"",
            ""textOriginal"": ""Такой формат мне больше нравится"",
            ""authorDisplayName"": ""Nick Breege"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjShPCRdmJmh9le9ilW8inuHtbICunRw42v9g=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCIsCNLaLndTvxTiK4Kyyp0w"",
            ""authorChannelId"": {
                    ""value"": ""UCIsCNLaLndTvxTiK4Kyyp0w""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:46:42Z"",
            ""updatedAt"": ""2021-01-02T09:46:42Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""F9NAETugA5rBFJbMwDQ1nMVgkWM"",
      ""id"": ""UgwOQogk5PpMXRBa_Dt4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""rZ1fHvBYBbkuP1xLKaA_TZbSppM"",
          ""id"": ""UgwOQogk5PpMXRBa_Dt4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Супер"",
            ""textOriginal"": ""Супер"",
            ""authorDisplayName"": ""Az Buki"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngqL3ivqh6043sg-rCZJDXPBvNn3f3rMqM8KA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCFz7PnogFyyglobhrd-oVDw"",
            ""authorChannelId"": {
                    ""value"": ""UCFz7PnogFyyglobhrd-oVDw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:45:32Z"",
            ""updatedAt"": ""2021-01-02T09:45:32Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""fl9rpWKHu992Z9lHooqvX8mC-TA"",
      ""id"": ""UgzpSoEf5pjhBmJqq_14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""yn0ytjI0zLTePiFwb231n0j6aRU"",
          ""id"": ""UgzpSoEf5pjhBmJqq_14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денчик мне кажется в первой истории ты упустил одну ОЧЕНЬ существенную деталь, это чудо из 2020-го еще и трансвестит, это не баба, этот мир е*анулся окончательно..."",
            ""textOriginal"": ""Денчик мне кажется в первой истории ты упустил одну ОЧЕНЬ существенную деталь, это чудо из 2020-го еще и трансвестит, это не баба, этот мир е*анулся окончательно..."",
            ""authorDisplayName"": ""Iurii Brailko"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj-quq3docE2vG8P_ZL30R_IxgoPUauYNjbCLK32w=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCLNSqR0Pz9TYr_r-cKf-uDg"",
            ""authorChannelId"": {
                    ""value"": ""UCLNSqR0Pz9TYr_r-cKf-uDg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T09:41:06Z"",
            ""updatedAt"": ""2021-01-02T09:42:38Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""LABYaHQtCusDx-RUn90-i74eLrM"",
      ""id"": ""Ugw0HO2rJg-O0QhS-oF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""nnBurr_b5W1ou2Gr5TZqliDZFhs"",
          ""id"": ""Ugw0HO2rJg-O0QhS-oF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Нет равенства в штатах, не вводи в заблуждение"",
            ""textOriginal"": ""Нет равенства в штатах, не вводи в заблуждение"",
            ""authorDisplayName"": ""Роман Гузев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjggx-xryZwW2LI8m9jQSsQwLei-1HgIHw3PxmeUA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCBVbf3srVk_tlxBytzS1l5A"",
            ""authorChannelId"": {
                    ""value"": ""UCBVbf3srVk_tlxBytzS1l5A""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:38:36Z"",
            ""updatedAt"": ""2021-01-02T09:38:36Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""z_1vmNfQOWOCXfVD_jLIsVWu6q8"",
      ""id"": ""Ugx2vj0VDBpZZhZfwfR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""iOGgFY1wqTs1nb_5XGwcdPVuJGI"",
          ""id"": ""Ugx2vj0VDBpZZhZfwfR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Как выбрать нишуу"",
            ""textOriginal"": ""Как выбрать нишуу"",
            ""authorDisplayName"": ""eli na"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwng7yE6wUsWAQobzR5WMJbVUyuvOdv8t0eZFpA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCdA1IhIe-IWukDg5bgfLpSA"",
            ""authorChannelId"": {
                    ""value"": ""UCdA1IhIe-IWukDg5bgfLpSA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:35:00Z"",
            ""updatedAt"": ""2021-01-02T09:35:00Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""u6wSNuRsJvJLEUnI_gTiXNvZiXg"",
      ""id"": ""UgwURtsE7YY_i9stkMh4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""HA1vIP5h3ceWgYqupc_LSwEFup4"",
          ""id"": ""UgwURtsE7YY_i9stkMh4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Если все поровну то женщина будет привлекать привлекательного парня, по моему это прекрасно.\u003cbr /\u003eСтрашные мужики с деньгами негодуют?"",
            ""textOriginal"": ""Если все поровну то женщина будет привлекать привлекательного парня, по моему это прекрасно.\nСтрашные мужики с деньгами негодуют?"",
            ""authorDisplayName"": ""NikkyChun NikkyChun"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjmcKWZVB7uUK1ye6XPs-KczBsjrwDLwbpHWvHT=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCZmg6d1EhoSxbS3Y_XcMduA"",
            ""authorChannelId"": {
                    ""value"": ""UCZmg6d1EhoSxbS3Y_XcMduA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T09:34:21Z"",
            ""updatedAt"": ""2021-01-02T09:34:21Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 11,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""fln26eiyWjpF7_o2dAS4SoYWNs8"",
      ""id"": ""UgzbI1rCDrLpX55D5bd4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""sR_scfNtBS81emFKFDsk8g1UIpk"",
          ""id"": ""UgzbI1rCDrLpX55D5bd4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Ден, у тебя виниры?"",
            ""textOriginal"": ""Ден, у тебя виниры?"",
            ""authorDisplayName"": ""Себастьян Перейро"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj_YmSz0Yb0VF2eZq2y5MkxYuL_KMT75w_ByBZksA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCpJpcEdiFPAvSY7nawQTHTA"",
            ""authorChannelId"": {
                    ""value"": ""UCpJpcEdiFPAvSY7nawQTHTA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:26:49Z"",
            ""updatedAt"": ""2021-01-02T09:26:49Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""xgKKqNuml7ibCA1V2XDsMJLL0tE"",
      ""id"": ""Ugxj5ooADGtqCHXH3CR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""dhETDdC3aokQsWEuODmav9PPc3M"",
          ""id"": ""Ugxj5ooADGtqCHXH3CR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Ден, камера новая?\u003cbr /\u003eКартинка вообще огонь стала!\u003cbr /\u003e\u003cbr /\u003eЗаписался к тебе в школу, решил монетой отблагодарить за всю ту полезную инфу, которой делишься уже 10 лет!\u003cbr /\u003e\u003cbr /\u003eМного полезного взял у тебя для своего личного развития, БлагоДарю, Брат!\u003cbr /\u003eЗдоровья тебе крепкого и дальнейших успехов в самореализации!"",
            ""textOriginal"": ""Ден, камера новая?\nКартинка вообще огонь стала!\n\nЗаписался к тебе в школу, решил монетой отблагодарить за всю ту полезную инфу, которой делишься уже 10 лет!\n\nМного полезного взял у тебя для своего личного развития, БлагоДарю, Брат!\nЗдоровья тебе крепкого и дальнейших успехов в самореализации!"",
            ""authorDisplayName"": ""РАДМИР РУС"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhfFI8A7luYsmsjg4wwe6X140UrnhFItw64Uph34g=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCZmq25a-ta3qFaLk0KG4ywg"",
            ""authorChannelId"": {
                    ""value"": ""UCZmq25a-ta3qFaLk0KG4ywg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:26:16Z"",
            ""updatedAt"": ""2021-01-02T09:27:03Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""29uO9V52zK766VWoIec7V6xp_EE"",
      ""id"": ""UgxU0XT2_qGdHSISopR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""SUgh96tjBxTZ_ZdEq4Ti25FyFVQ"",
          ""id"": ""UgxU0XT2_qGdHSISopR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""И тебя Дэн С НГ)) Мы тож тут рядом будем)))"",
            ""textOriginal"": ""И тебя Дэн С НГ)) Мы тож тут рядом будем)))"",
            ""authorDisplayName"": ""Макс Богачёв"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj81SbNudVmM9Xc8Id6wyUQWDRhApjM2UR1Xxi7AQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC_7x9pEfzjcvxladflbOxYg"",
            ""authorChannelId"": {
                    ""value"": ""UC_7x9pEfzjcvxladflbOxYg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T09:22:21Z"",
            ""updatedAt"": ""2021-01-02T09:22:21Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""lKhcL0lk_-3lfNeiGo4CCmJR3_0"",
      ""id"": ""UgwI4f5vTbrQLqK3-s14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""jgSnPbvtHH3siOT-zR0xPtXAVEk"",
          ""id"": ""UgwI4f5vTbrQLqK3-s14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": "":) Годный подбор тем."",
            ""textOriginal"": "":) Годный подбор тем."",
            ""authorDisplayName"": ""Skif Zombi"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniE-yVAKx8ZbkPRl5OVSPCOxjbsbfvCcSb1zQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC87BpS4jAEM2ppAHo6ZllOA"",
            ""authorChannelId"": {
                    ""value"": ""UC87BpS4jAEM2ppAHo6ZllOA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:22:07Z"",
            ""updatedAt"": ""2021-01-02T09:22:07Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""OIZQabno2dhf6vZNxfdwR3ff3wE"",
      ""id"": ""Ugyq0_HtMQ90M0Slr3R4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""m-4vWdqvgpLS5yEJ0QWL1NC6nEA"",
          ""id"": ""Ugyq0_HtMQ90M0Slr3R4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Сила с вами, брат! \u003cbr /\u003eКакой самый подходящий возраст для создания ребёнка . Преподаватель по биологии говорила 19 лет для женского пола, так ли это, как считаешь, и что насчёт мужского? Здоровье будущего ребёнка, генетика от каких факторов зависит сильно, а от каких меньше?\u003cbr /\u003eКак улучшить физическую выносливость с пользой для здоровья? До сих пор помню сюжет про гипертрофию L и D, думаю много поменялось за 6, а то и больше лет.\u003cbr /\u003eСпасибо огромное за полезнейшие сюжеты!!! Сил неисчерпаемых, здоровья бесконечного тебе братик!!!"",
            ""textOriginal"": ""Сила с вами, брат! \nКакой самый подходящий возраст для создания ребёнка . Преподаватель по биологии говорила 19 лет для женского пола, так ли это, как считаешь, и что насчёт мужского? Здоровье будущего ребёнка, генетика от каких факторов зависит сильно, а от каких меньше?\nКак улучшить физическую выносливость с пользой для здоровья? До сих пор помню сюжет про гипертрофию L и D, думаю много поменялось за 6, а то и больше лет.\nСпасибо огромное за полезнейшие сюжеты!!! Сил неисчерпаемых, здоровья бесконечного тебе братик!!!"",
            ""authorDisplayName"": ""Vladislav Zhurov"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhF2pSCR3GWE0gtAQOX3XKYFI7P_0EdJom38g=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCZs2-QjCajrUwxE1QKWhEgQ"",
            ""authorChannelId"": {
                    ""value"": ""UCZs2-QjCajrUwxE1QKWhEgQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 17,
            ""publishedAt"": ""2021-01-02T09:21:48Z"",
            ""updatedAt"": ""2021-01-02T09:21:48Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""vroHcJxyrjJOCaGyON_wD6NBUxE"",
      ""id"": ""UgxSMMA_sbIf5HiQelF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""Z5aqWmuaS6tUDXypdgYrqaJuEk4"",
          ""id"": ""UgxSMMA_sbIf5HiQelF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Я такой плакат с пухляшей не нашел - это где?"",
            ""textOriginal"": ""Я такой плакат с пухляшей не нашел - это где?"",
            ""authorDisplayName"": ""Egor Komarov"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnguFyO6K1rM_B4nTtEep1w1q_zBNcTJAODN6O2h=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCB4_pEP7MEUkCdkhb5cKOJg"",
            ""authorChannelId"": {
                    ""value"": ""UCB4_pEP7MEUkCdkhb5cKOJg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:18:15Z"",
            ""updatedAt"": ""2021-01-02T09:18:15Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""jZMcrQmBDiji-DfJcp73jRJz5-Q"",
      ""id"": ""UgyiwP0MwNTDJ7t34yt4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""5xoLdpVaWMi6E7qLqy31dG4osz0"",
          ""id"": ""UgyiwP0MwNTDJ7t34yt4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""О норм дэнчик))) Да самое плохое сейчас = пищевая наркомания."",
            ""textOriginal"": ""О норм дэнчик))) Да самое плохое сейчас = пищевая наркомания."",
            ""authorDisplayName"": ""Макс Богачёв"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj81SbNudVmM9Xc8Id6wyUQWDRhApjM2UR1Xxi7AQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC_7x9pEfzjcvxladflbOxYg"",
            ""authorChannelId"": {
                    ""value"": ""UC_7x9pEfzjcvxladflbOxYg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:18:00Z"",
            ""updatedAt"": ""2021-01-02T09:18:00Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""zznlKKUkYOM1tX777AppJC8a2E8"",
      ""id"": ""UgyK0V5ard7IRZvLkBl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""rR8tHfDvRkylFcYYZ9z-a4QsGWo"",
          ""id"": ""UgyK0V5ard7IRZvLkBl4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Это был лучший год в жизни нашей семьи. В том числе от части благодаря тебе."",
            ""textOriginal"": ""Это был лучший год в жизни нашей семьи. В том числе от части благодаря тебе."",
            ""authorDisplayName"": ""Нутрициолог Ольга Кустова"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniJoConB8vJ1nufTDT8B0bNq04SCIuKOTCzRrTlvA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCnxZofOJy5J_Okl_P2DFbsw"",
            ""authorChannelId"": {
                    ""value"": ""UCnxZofOJy5J_Okl_P2DFbsw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 3,
            ""publishedAt"": ""2021-01-02T09:16:53Z"",
            ""updatedAt"": ""2021-01-02T09:16:53Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""2hFCdmtWMix1bkVPf14Tlv-odq0"",
      ""id"": ""Ugy4D5QvX0LMBCDbjTl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""MiyG79jf_Cv9Scldx8dGCEXcYK4"",
          ""id"": ""Ugy4D5QvX0LMBCDbjTl4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""У Денчика Новоселов и Савельев вместо Энгельса и Маркса"",
            ""textOriginal"": ""У Денчика Новоселов и Савельев вместо Энгельса и Маркса"",
            ""authorDisplayName"": ""Адилет Берик"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniYXiYYC6KciPGRCHZVbRhiPshJSYB35pADanwswQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCwJJ2RreXcGZtRCeruIxxqQ"",
            ""authorChannelId"": {
                    ""value"": ""UCwJJ2RreXcGZtRCeruIxxqQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T09:15:44Z"",
            ""updatedAt"": ""2021-01-02T09:15:44Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""wVlbVZHyRoFgVCBFV-lDZe7Jbu4"",
      ""id"": ""UgyTbaMUC7PNeU3tnW94AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""inbz4NYszi9ETjYJpsdhsEFxzMU"",
          ""id"": ""UgyTbaMUC7PNeU3tnW94AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""С Новым Годом Денис Владимирович"",
            ""textOriginal"": ""С Новым Годом Денис Владимирович"",
            ""authorDisplayName"": ""Нутрициолог Ольга Кустова"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniJoConB8vJ1nufTDT8B0bNq04SCIuKOTCzRrTlvA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCnxZofOJy5J_Okl_P2DFbsw"",
            ""authorChannelId"": {
                    ""value"": ""UCnxZofOJy5J_Okl_P2DFbsw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T09:15:09Z"",
            ""updatedAt"": ""2021-01-02T09:15:09Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""67JeCLa5oDQYW21CIAaJgkWvOcI"",
      ""id"": ""UgyryVlfg1xi_mg7lwV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""31HNsbUUCq0xCQZayzsKZrSYQ3M"",
          ""id"": ""UgyryVlfg1xi_mg7lwV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Осталась неделя до обучения! Ждём"",
            ""textOriginal"": ""Осталась неделя до обучения! Ждём"",
            ""authorDisplayName"": ""Нутрициолог Ольга Кустова"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniJoConB8vJ1nufTDT8B0bNq04SCIuKOTCzRrTlvA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCnxZofOJy5J_Okl_P2DFbsw"",
            ""authorChannelId"": {
                    ""value"": ""UCnxZofOJy5J_Okl_P2DFbsw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 4,
            ""publishedAt"": ""2021-01-02T09:14:50Z"",
            ""updatedAt"": ""2021-01-02T09:14:50Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""NwIeoWAaO4XmrNgDlP_TTVLT8Ec"",
      ""id"": ""UgwpCr5LZAoitGSIMuZ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""aBQ9GRJJuRtxIgmuIGQa7MqUbuY"",
          ""id"": ""UgwpCr5LZAoitGSIMuZ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Эксперимент в советской столовке в общем получился, потому что и власти верили в коммунизм.  Сейчас люди с такими же убеждениями, но к власти пришли крысы, которые обворовывают казну и высасывают все соки из людей."",
            ""textOriginal"": ""Эксперимент в советской столовке в общем получился, потому что и власти верили в коммунизм.  Сейчас люди с такими же убеждениями, но к власти пришли крысы, которые обворовывают казну и высасывают все соки из людей."",
            ""authorDisplayName"": ""Alex Man"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngWtqOi16xkiGfxWrNZZbFx9QUAj_KQQzd_zuMR=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCb8XavRZI73KHUcumJyhrDg"",
            ""authorChannelId"": {
                    ""value"": ""UCb8XavRZI73KHUcumJyhrDg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T09:14:01Z"",
            ""updatedAt"": ""2021-01-02T09:14:01Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""TYRTK3Yw497WON6cSWIIA2zFsoc"",
      ""id"": ""UgwvaYritc162cKqVpt4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""TzozwLzvz5FpeYtwynluFoKfUKM"",
          ""id"": ""UgwvaYritc162cKqVpt4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=4m10s\""\u003e4:10\u003c/a\u003e это говорит о том что мак спонсирует феминизм, а пирамидка белая"",
            ""textOriginal"": ""4:10 это говорит о том что мак спонсирует феминизм, а пирамидка белая"",
            ""authorDisplayName"": ""Вячеслав Медведев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngH_4_7v0K_TaVfJrzGrNvJB_37NSYbkf8cHQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCzSpD5Jn5ZN0tlJeuEvDa7A"",
            ""authorChannelId"": {
                    ""value"": ""UCzSpD5Jn5ZN0tlJeuEvDa7A""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:12:38Z"",
            ""updatedAt"": ""2021-01-02T09:16:58Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Gao1YTX1A4QFYRiM6CSNxYPKFxw"",
      ""id"": ""UgxXLr1AT4BwqOXojs14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""fsAWFjFyFU-sI8NPtd451esnZgk"",
          ""id"": ""UgxXLr1AT4BwqOXojs14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Отличный обзор ситуаций в мире и в истории, всегда приятно смотреть на тебя, Денис! С новым годом!"",
            ""textOriginal"": ""Отличный обзор ситуаций в мире и в истории, всегда приятно смотреть на тебя, Денис! С новым годом!"",
            ""authorDisplayName"": ""Артем Бабаев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhmRxc9pqF1dUlcaEOzhIRrbxgh3Z_0VK7wCw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCAPBNjqYz0elqmsOn_UYC7w"",
            ""authorChannelId"": {
                    ""value"": ""UCAPBNjqYz0elqmsOn_UYC7w""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T09:08:30Z"",
            ""updatedAt"": ""2021-01-02T09:08:30Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""K5GOsNL5WQ8zdVzgEGaWbtbMF80"",
      ""id"": ""Ugzhu9sPVfwYgtZr7Np4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""QR8kWP2wccZS08xronOr1jhV5Bo"",
          ""id"": ""Ugzhu9sPVfwYgtZr7Np4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""О суббота после праздников. А тут новый супер контент от Денчика. Ставлю чай.  С Новым Годом братья. Аминь. :)"",
            ""textOriginal"": ""О суббота после праздников. А тут новый супер контент от Денчика. Ставлю чай.  С Новым Годом братья. Аминь. :)"",
            ""authorDisplayName"": ""Prizrak Prizrak"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwni4LnLyh1ymXu5HEnS5VOXMCAzTa43E-1VPCs1E=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCdn8Y6haN0OPZ2YlSrw2pbg"",
            ""authorChannelId"": {
                    ""value"": ""UCdn8Y6haN0OPZ2YlSrw2pbg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T09:02:18Z"",
            ""updatedAt"": ""2021-01-02T09:02:18Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""2r6JeBLHzDihYbf6LqVBkYtXeMQ"",
      ""id"": ""Ugwgo1U4asQ7CBW2ej14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""lVArHqKt2y_A9JnnidcNczTubQ4"",
          ""id"": ""Ugwgo1U4asQ7CBW2ej14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, благодарю за тёплые поздравления и искренне пожелания! Благодарю за твоё интересное и познавательное творчество!) Пусть в новом году твой раскрученный маховик публичности продолжит набирать обороты в геометрической прогрессии!) Вдохновения! Крепкого Здоровья! И Огромного Человеческого Счастья тебе и твоим близким!)\u003cbr /\u003eP. S. Всех с наступившим Новым Годом! Пусть Ваши мечты превратятся в Цели! Ваше намерение проявит их из тумана грёз, а ваша настойчивость и методичность поможет достичь желаемого!) Уроки Дэнчика в помощь!) \u003cbr /\u003eДа прибудет с Вами Сила Друзья!)"",
            ""textOriginal"": ""Денис, благодарю за тёплые поздравления и искренне пожелания! Благодарю за твоё интересное и познавательное творчество!) Пусть в новом году твой раскрученный маховик публичности продолжит набирать обороты в геометрической прогрессии!) Вдохновения! Крепкого Здоровья! И Огромного Человеческого Счастья тебе и твоим близким!)\nP. S. Всех с наступившим Новым Годом! Пусть Ваши мечты превратятся в Цели! Ваше намерение проявит их из тумана грёз, а ваша настойчивость и методичность поможет достичь желаемого!) Уроки Дэнчика в помощь!) \nДа прибудет с Вами Сила Друзья!)"",
            ""authorDisplayName"": ""Степан Ионенко"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj1PbOT2WYCL1M3xSiFiOndpLklePabgmfoowkIqg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UClNmfIf2fxs1B1fQueOp05w"",
            ""authorChannelId"": {
                    ""value"": ""UClNmfIf2fxs1B1fQueOp05w""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:02:06Z"",
            ""updatedAt"": ""2021-01-02T09:09:43Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""eTX3zD2KBRlGFzPg_JaKSRvrUjg"",
      ""id"": ""UgxnhxjaKUhW-fVQuQB4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""qSU6GKhkDpOTqDqvKX11Zvlk4S8"",
          ""id"": ""UgxnhxjaKUhW-fVQuQB4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Девушка на втором постеры чёрная!"",
            ""textOriginal"": ""Девушка на втором постеры чёрная!"",
            ""authorDisplayName"": ""ewerett donelli"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjs-glki_9O7VCQODy9D_TLwWiBO7-yxZSmwCj1HQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCVxqEvKn-MeKrVkS7h08IMg"",
            ""authorChannelId"": {
                    ""value"": ""UCVxqEvKn-MeKrVkS7h08IMg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T09:01:42Z"",
            ""updatedAt"": ""2021-01-02T09:01:42Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""RFsow8VA3P4lsdAGmj3Q1uiPnOo"",
      ""id"": ""UgyuExHvPkV4AraGepR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ZNJDJ5Ij-UFNjTr-Azm2z3Jahf0"",
          ""id"": ""UgyuExHvPkV4AraGepR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""дэнчик, \u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=10m00s\""\u003e10:00\u003c/a\u003e - зачем независимой женщине за собой следить? - 1. чтобы чувствовать себя красоткой. это чувство сильно влияет на их счастье. 2. чтобы заинтересовать наиболее интересных для неё мужчин. если хочет замуж за бреда пита - придётся соответствовать! - так что мотивация вовсе не пропадает. пока есть мужики которые ей интересны. а если мужики пошли г*вённые, бестолковые и никчёмные - тогда действительно зачем ей стараться. чтобы ублажить этих никчёмышей? другое дело - чтобы заинтересовать лучших мужчин!"",
            ""textOriginal"": ""дэнчик, 10:00 - зачем независимой женщине за собой следить? - 1. чтобы чувствовать себя красоткой. это чувство сильно влияет на их счастье. 2. чтобы заинтересовать наиболее интересных для неё мужчин. если хочет замуж за бреда пита - придётся соответствовать! - так что мотивация вовсе не пропадает. пока есть мужики которые ей интересны. а если мужики пошли г*вённые, бестолковые и никчёмные - тогда действительно зачем ей стараться. чтобы ублажить этих никчёмышей? другое дело - чтобы заинтересовать лучших мужчин!"",
            ""authorDisplayName"": ""ты ли визор?"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjPai5mw27oalDEl4IZLN7-N2POBd83uyuqBA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCF_hqAbqKnX6sQixxIdWEig"",
            ""authorChannelId"": {
                    ""value"": ""UCF_hqAbqKnX6sQixxIdWEig""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:58:49Z"",
            ""updatedAt"": ""2021-01-02T08:58:49Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""GdhJ7Utj1uz3QO56cPPsmBjiRUY"",
      ""id"": ""Ugwbi43Y5i9sV6IPdkh4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""z4t6WLE4GBOLYs4KkqFjmwqsAdk"",
          ""id"": ""Ugwbi43Y5i9sV6IPdkh4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""А советский пекарь умер от голода, в блокадном Ленинграде. Вот что такое сила духа и убеждения."",
            ""textOriginal"": ""А советский пекарь умер от голода, в блокадном Ленинграде. Вот что такое сила духа и убеждения."",
            ""authorDisplayName"": ""MWWM"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj0aIcn2pnRUcUtVowS-SASV9imY4vXmyrgEDcP=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCQVENAdDQFXocJhekDPignA"",
            ""authorChannelId"": {
                    ""value"": ""UCQVENAdDQFXocJhekDPignA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T08:57:51Z"",
            ""updatedAt"": ""2021-01-02T08:57:51Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""kkrPDsk3gxi7ARZC-K5hUnJGgHI"",
      ""id"": ""UgyqPEX9AOFd1H6lrpB4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""I63ESPEIW7ZgYN48KpYXmV1fntk"",
          ""id"": ""UgyqPEX9AOFd1H6lrpB4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""100 пудово Денчика купили власти чтобы мы понимали как все идет и не бомбили на власть)"",
            ""textOriginal"": ""100 пудово Денчика купили власти чтобы мы понимали как все идет и не бомбили на власть)"",
            ""authorDisplayName"": ""Wasili Meier"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniYMwkL4RjxmIDg4w7ZHchE20LtBROLGw8RwMDx=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC9C3wN4qVuazNnM-ZCf_KtQ"",
            ""authorChannelId"": {
                    ""value"": ""UC9C3wN4qVuazNnM-ZCf_KtQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:54:25Z"",
            ""updatedAt"": ""2021-01-02T08:54:25Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""-y-ZuQKtG86uP2ydCu3xxe6BWDI"",
      ""id"": ""UgxmgGKD12EMYl5x8CZ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""jWrCdus4qlZOOn9TV3qjPZucRH0"",
          ""id"": ""UgxmgGKD12EMYl5x8CZ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""💪💪💪💪✌️✌️✌️✌️"",
            ""textOriginal"": ""💪💪💪💪✌️✌️✌️✌️"",
            ""authorDisplayName"": ""Стас Хуторнюк"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwni3tOxQR4xJyqgkZ7IQN5RFI5zb9x16F8QcgA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC5QzrsYPYlvUw0DMNfguAtA"",
            ""authorChannelId"": {
                    ""value"": ""UC5QzrsYPYlvUw0DMNfguAtA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:53:46Z"",
            ""updatedAt"": ""2021-01-02T08:53:46Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""P3k0AjWYJzll2bdzIsLJN0E5cCw"",
      ""id"": ""UgxYFblcxQ1ghthYDYV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""-krnCcCdxDUXFqc4tVKmAz5Uqlg"",
          ""id"": ""UgxYFblcxQ1ghthYDYV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""дэнчик. про бодипозитив. кажется ты неправильно его понимаешь. бодипозитив не против здоровья а наоборот - за него. здоровье психики не менее важно чем здоровье тела. разумеется нужно стремиться и к зожу и к красоте. но загоняться,комплексовать,депресовать если ты не идеален - это признак нездоровья психики. бодипозитив за здоровое отношение к телу: какое тело имеешь - цени его! люби себя. таким какой есть. и старайся становиться лучше, здоровее душой и телом и счастливее каждый день."",
            ""textOriginal"": ""дэнчик. про бодипозитив. кажется ты неправильно его понимаешь. бодипозитив не против здоровья а наоборот - за него. здоровье психики не менее важно чем здоровье тела. разумеется нужно стремиться и к зожу и к красоте. но загоняться,комплексовать,депресовать если ты не идеален - это признак нездоровья психики. бодипозитив за здоровое отношение к телу: какое тело имеешь - цени его! люби себя. таким какой есть. и старайся становиться лучше, здоровее душой и телом и счастливее каждый день."",
            ""authorDisplayName"": ""ты ли визор?"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjPai5mw27oalDEl4IZLN7-N2POBd83uyuqBA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCF_hqAbqKnX6sQixxIdWEig"",
            ""authorChannelId"": {
                    ""value"": ""UCF_hqAbqKnX6sQixxIdWEig""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:53:30Z"",
            ""updatedAt"": ""2021-01-02T08:53:48Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""8V18vLsCaYG1HtSEygOAKAgFcTI"",
      ""id"": ""UgyN1PcgixRVUhZWwXl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""l4Bzs5xcZwsjPAIIlZ7B5WcpPlM"",
          ""id"": ""UgyN1PcgixRVUhZWwXl4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=21m00s\""\u003e21:00\u003c/a\u003e не слушайте, что они говорят, смотрите что они делают"",
            ""textOriginal"": ""21:00 не слушайте, что они говорят, смотрите что они делают"",
            ""authorDisplayName"": ""Comrade"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnifH2TQVYJq0eAUB4Wjx_GPAw_AfazBqvLTNB713w=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC7SbFlhrR-tlGb_ZQ61xXAw"",
            ""authorChannelId"": {
                    ""value"": ""UC7SbFlhrR-tlGb_ZQ61xXAw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T08:52:47Z"",
            ""updatedAt"": ""2021-01-02T08:52:47Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""m-2RUUEuEywqmIb8ByKU_WdHKEY"",
      ""id"": ""Ugx_976iN3ScUHKWhTR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""meu5TJdc1qEHtPwIrMBn715iCbY"",
          ""id"": ""Ugx_976iN3ScUHKWhTR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Ну один сюжет от Денчика вышел...этот год уже не прошёл зря..."",
            ""textOriginal"": ""Ну один сюжет от Денчика вышел...этот год уже не прошёл зря..."",
            ""authorDisplayName"": ""Sergio's Covers"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniTEZ9FfX0dn0N_moJIbiwA7g34-cL9Zn5fjDImNQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCIlpcstUrfvAl0lxHHksXig"",
            ""authorChannelId"": {
                    ""value"": ""UCIlpcstUrfvAl0lxHHksXig""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T08:51:19Z"",
            ""updatedAt"": ""2021-01-02T08:51:19Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""dYLFqaSXIHeTMs9AQbHMXqjd0-A"",
      ""id"": ""UgzF4hPIfQjuvRujx1V4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""JGwFSlEXRGjSh8r2l_z6ltqSY6U"",
          ""id"": ""UgzF4hPIfQjuvRujx1V4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Насчет \u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=0m13s\""\u003e0:13\u003c/a\u003e ,  люди это социальные существа ,готовые помочь : исходя из своего опыта биолога , и на личном опыте   долгой жизни , то классификация Чарльза Дарвина мне ближе :\u003cbr /\u003eТип - хордовые \u003cbr /\u003eПодтип - позвоночные \u003cbr /\u003eКласс - животные \u003cbr /\u003eПодкласс  - род - приматы \u003cbr /\u003eВид - крупные приматы \u003cbr /\u003eПодвид - homo sapiens , ..\u003cbr /\u003eПрофессор С. Савельев исследователь мозга человека , рассматривающий человечество как более развитых приматов , определил главный инстинкт ,,человека&quot; , на котором построено всё человеческое сообщество , не зависимо от стран и наций .\u003cbr /\u003eЭтот инстинкт ,гораздо сильнее добывания пищи , размножения , поведения , это инстинкт доминанты .\u003cbr /\u003eЕсли примат доминантный , то у него всегда будет и пища и самки , и безопасность . Примеров приводить не стану ,они на виду . Кроме того думаю , что подвид гомо сапиенс , это вообще ошибка Создателя ,надо было остановиться на мартышках  горилллах , ну ещё орангутангах  ,даже не создавать шимпанзе , так уже ошибка в  справочниках о  пищевых предпочтениях : нам в справочниках пишут , что эти обезьяны веганы , однако они вполне успешно охотятся на своих же собратьев помельче , и прекрасно их жрут  живьём  а если внимательно присмотреться то  многие люди это копия шимпнзе , и по поведению и по внешности ..почти у каждого человека есть черты на лице , похожие на шимпанзе .\u003cbr /\u003eСобственно наше общество , построено так же по законам диких  джунглей  , где выживает наиболее сильный , хитрый , изворотливый , а поскольку люди научились  писать и читать , то доминирующие особи пропиасали им законы , где доминанту всё , а остальным ничего . Иван Андреевич Крылов , высказал идею общества гомо сапиенсов ,двумя фразами , в басне ,,Волк и Ягнёнок &quot; : \u003cbr /\u003e&quot; - Ты виноват уж тем , что хочется мне кушать &quot; , сказал и в темный лес ягненка поволок ,, . \u003cbr /\u003eВсем сапиенсам добра и счастья . 😀"",
            ""textOriginal"": ""Насчет 0:13 ,  люди это социальные существа ,готовые помочь : исходя из своего опыта биолога , и на личном опыте   долгой жизни , то классификация Чарльза Дарвина мне ближе :\nТип - хордовые \nПодтип - позвоночные \nКласс - животные \nПодкласс  - род - приматы \nВид - крупные приматы \nПодвид - homo sapiens , ..\nПрофессор С. Савельев исследователь мозга человека , рассматривающий человечество как более развитых приматов , определил главный инстинкт ,,человека\"" , на котором построено всё человеческое сообщество , не зависимо от стран и наций .\nЭтот инстинкт ,гораздо сильнее добывания пищи , размножения , поведения , это инстинкт доминанты .\nЕсли примат доминантный , то у него всегда будет и пища и самки , и безопасность . Примеров приводить не стану ,они на виду . Кроме того думаю , что подвид гомо сапиенс , это вообще ошибка Создателя ,надо было остановиться на мартышках  горилллах , ну ещё орангутангах  ,даже не создавать шимпанзе , так уже ошибка в  справочниках о  пищевых предпочтениях : нам в справочниках пишут , что эти обезьяны веганы , однако они вполне успешно охотятся на своих же собратьев помельче , и прекрасно их жрут  живьём  а если внимательно присмотреться то  многие люди это копия шимпнзе , и по поведению и по внешности ..почти у каждого человека есть черты на лице , похожие на шимпанзе .\nСобственно наше общество , построено так же по законам диких  джунглей  , где выживает наиболее сильный , хитрый , изворотливый , а поскольку люди научились  писать и читать , то доминирующие особи пропиасали им законы , где доминанту всё , а остальным ничего . Иван Андреевич Крылов , высказал идею общества гомо сапиенсов ,двумя фразами , в басне ,,Волк и Ягнёнок \"" : \n\"" - Ты виноват уж тем , что хочется мне кушать \"" , сказал и в темный лес ягненка поволок ,, . \nВсем сапиенсам добра и счастья . 😀"",
            ""authorDisplayName"": ""Gold Djon Good loock"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngU8kldSN6euDdB5awazMoRpaFR1M8hHdaG0Q=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCw7pG_jBNyAiSzicVRKiQVg"",
            ""authorChannelId"": {
                    ""value"": ""UCw7pG_jBNyAiSzicVRKiQVg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:50:44Z"",
            ""updatedAt"": ""2021-01-02T08:50:44Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""0Xtp7jcbEemfa17v0up7JvVvUj0"",
      ""id"": ""Ugwp9aiRd84GS1b0RwJ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""I7bw6_TLygxvZlR-F0rbia4JEpY"",
          ""id"": ""Ugwp9aiRd84GS1b0RwJ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Это не просто толстая модель в первой новости, это транс, а не женщина!!"",
            ""textOriginal"": ""Это не просто толстая модель в первой новости, это транс, а не женщина!!"",
            ""authorDisplayName"": ""Candice Shand"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngQhbtCWMjgtCX53_iQL0QcSgd1ph-NxFjF=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCQdrdZsu8K9RB7MJY4VkAgg"",
            ""authorChannelId"": {
                    ""value"": ""UCQdrdZsu8K9RB7MJY4VkAgg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T08:50:28Z"",
            ""updatedAt"": ""2021-01-02T08:50:28Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""FShYn78GvApzxbIKd36_XZxmQlg"",
      ""id"": ""Ugw8p79q5ll1khDV3Kh4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""hGdi94sPlGswaH0z1jDR-_M9JrQ"",
          ""id"": ""Ugw8p79q5ll1khDV3Kh4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Про детройд, на youtube есть ролик,\u003cbr /\u003eВеличие и бездна. Как рухнул детройд\u003cbr /\u003eОчень интересный, рекомендую"",
            ""textOriginal"": ""Про детройд, на youtube есть ролик,\nВеличие и бездна. Как рухнул детройд\nОчень интересный, рекомендую"",
            ""authorDisplayName"": ""Сергей Воеводин"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhwEUiMrq67MSZ-LatPmHA8_uh5G5S5C5N72hFW=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCm-cqQFo0MR2qgYfRFedqJw"",
            ""authorChannelId"": {
                    ""value"": ""UCm-cqQFo0MR2qgYfRFedqJw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:50:22Z"",
            ""updatedAt"": ""2021-01-02T08:50:22Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""rMj2vvezJ5fUB4oGSsJwpzrlNK8"",
      ""id"": ""Ugz90KH7jH6EovAZGZ14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""jklaMDE4yOjS4DvpKwj4wwnCT7c"",
          ""id"": ""Ugz90KH7jH6EovAZGZ14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Лицезреть твою физиономию по утрам информативно, поучительно, радостно и жизнеутверждаюше) Жги ОТЕЦ Мой)) отец во крипте)))"",
            ""textOriginal"": ""Лицезреть твою физиономию по утрам информативно, поучительно, радостно и жизнеутверждаюше) Жги ОТЕЦ Мой)) отец во крипте)))"",
            ""authorDisplayName"": ""николай иванов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniNPr7OJoucYMGW0qOk6uGQhIaP6i63pTk-lw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCXtyds6DUUwdDYpydvzbtdw"",
            ""authorChannelId"": {
                    ""value"": ""UCXtyds6DUUwdDYpydvzbtdw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T08:49:31Z"",
            ""updatedAt"": ""2021-01-02T08:49:31Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""dPZCy1OPnbp-IVEiJ6S-MIG3jpw"",
      ""id"": ""Ugwh6Gll9DQgKh24yB14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""0d9cw2BhFg1nPY1v3kKWeQ-6-DA"",
          ""id"": ""Ugwh6Gll9DQgKh24yB14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=27m14s\""\u003e27:14\u003c/a\u003e очень важное! Не надо мотивировать себя, просто перестать делать определённые вещи и всё направится само."",
            ""textOriginal"": ""27:14 очень важное! Не надо мотивировать себя, просто перестать делать определённые вещи и всё направится само."",
            ""authorDisplayName"": ""yeko"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjZK75Jiropz0meL38kCDneWWP7putEYh-geg5S=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCDaVlUfWiMKJJiJZwhF1ttw"",
            ""authorChannelId"": {
                    ""value"": ""UCDaVlUfWiMKJJiJZwhF1ttw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T08:47:51Z"",
            ""updatedAt"": ""2021-01-02T08:47:51Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Vx4w8FokTp8-ZDu9aYlzcncnb2A"",
      ""id"": ""UgzYk1-J4bZsLxwoKxh4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ZFMsCFbiupN6bCqY559_e8H9zAo"",
          ""id"": ""UgzYk1-J4bZsLxwoKxh4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Ден, биток вплотную подкрался к 30К. Как думаешь, что дальше? Взрывной рост, коррекция, плато или обвал?"",
            ""textOriginal"": ""Ден, биток вплотную подкрался к 30К. Как думаешь, что дальше? Взрывной рост, коррекция, плато или обвал?"",
            ""authorDisplayName"": ""DOCTOR LEAF"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh0-W0uLn4ww2iLjVvZfDXVN0Bb0OGcCvu_1WGUsA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCpkvIZsfAeeGRBgIPHmiW8g"",
            ""authorChannelId"": {
                    ""value"": ""UCpkvIZsfAeeGRBgIPHmiW8g""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:46:00Z"",
            ""updatedAt"": ""2021-01-02T08:46:00Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""QgV33NPIdW9-bQR6MInTSK7h8A4"",
      ""id"": ""UgwUxwVRWGc-s_2xDLd4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ZnbS8y9YIUe7t1TbSFh2S0EKI_g"",
          ""id"": ""UgwUxwVRWGc-s_2xDLd4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Обожаю это"",
            ""textOriginal"": ""Обожаю это"",
            ""authorDisplayName"": ""крут лев и тигр"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhvhOMC4cOUsHi7di1yYlM20yRb-UB96Bj_ZA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCs4x0qatwaa7ZXI-lTfdhgw"",
            ""authorChannelId"": {
                    ""value"": ""UCs4x0qatwaa7ZXI-lTfdhgw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:45:32Z"",
            ""updatedAt"": ""2021-01-02T08:45:32Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""LCmlvdDAg67JNoAVvvUN9QLnX9g"",
      ""id"": ""UgxJFB_Ju4UPHsUIk2V4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""BjZZV86ldSXU9JwnQ3iEgs571OM"",
          ""id"": ""UgxJFB_Ju4UPHsUIk2V4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денчик, спасибо за правильные примеры💪"",
            ""textOriginal"": ""Денчик, спасибо за правильные примеры💪"",
            ""authorDisplayName"": ""Смак Жыролысов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhKvUoZXb7d0oHhjfRb0lIDk4VWKfDSwc-90MXk=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCiMTM0Dg3myeZ2B3XoVPgQQ"",
            ""authorChannelId"": {
                    ""value"": ""UCiMTM0Dg3myeZ2B3XoVPgQQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:45:30Z"",
            ""updatedAt"": ""2021-01-02T08:45:30Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""sbOj3QeXuIImy5Lg1x33C3EfCL8"",
      ""id"": ""UgxNv5EFTPivLSJY7U94AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""cJ97lXM_-K2iIqHIXcejw-9HVrg"",
          ""id"": ""UgxNv5EFTPivLSJY7U94AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Мой учитель , спасибо за ролик"",
            ""textOriginal"": ""Мой учитель , спасибо за ролик"",
            ""authorDisplayName"": ""Pro Hohols"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj8ai_OPKmRJjM-G8VhmXBM2TKWWEwGkKG-ulEW=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC0r885Sv2tpvuAea70WpnhQ"",
            ""authorChannelId"": {
                    ""value"": ""UC0r885Sv2tpvuAea70WpnhQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:45:15Z"",
            ""updatedAt"": ""2021-01-02T08:45:15Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""5BnvjRz1v9IwBjsdgKk9JhlOXgA"",
      ""id"": ""Ugz-iCupFPtz2afjFop4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""8oJWDpwoEO0g_AEO3JwT6mBpzyE"",
          ""id"": ""Ugz-iCupFPtz2afjFop4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, привет! Расскажи пожалуйста про свое питание, сейчас, несколько лет назад, как пришел к текущему рациону? В общем понятно из многих твоих выпусков, но отдельного ролика я не нашел. Спасибо!"",
            ""textOriginal"": ""Денис, привет! Расскажи пожалуйста про свое питание, сейчас, несколько лет назад, как пришел к текущему рациону? В общем понятно из многих твоих выпусков, но отдельного ролика я не нашел. Спасибо!"",
            ""authorDisplayName"": ""Denis M."",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj4vz-iVZOOf5lCVTuMByh8EDXXqgctXsVjSCIiHg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCB9SNbrwfskXlbfKQmae9RA"",
            ""authorChannelId"": {
                    ""value"": ""UCB9SNbrwfskXlbfKQmae9RA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:44:31Z"",
            ""updatedAt"": ""2021-01-02T08:44:31Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""cVdSEcsutXM6GcFukRSViYGmi4k"",
      ""id"": ""UgwWLcZmEkbDgGVvpyR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""-kCQhy0L_mAZCCkAgvCMW4qvCzA"",
          ""id"": ""UgwWLcZmEkbDgGVvpyR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Для продолжительной жизни нужен голод, холод и движение , согласен, Денис?"",
            ""textOriginal"": ""Для продолжительной жизни нужен голод, холод и движение , согласен, Денис?"",
            ""authorDisplayName"": ""MWWM"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj0aIcn2pnRUcUtVowS-SASV9imY4vXmyrgEDcP=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCQVENAdDQFXocJhekDPignA"",
            ""authorChannelId"": {
                    ""value"": ""UCQVENAdDQFXocJhekDPignA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T08:44:10Z"",
            ""updatedAt"": ""2021-01-02T08:44:10Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""n90qxhz_0uSL1LiriDjPkj-UOKU"",
      ""id"": ""UgyXP3-YpITxt4BU3XR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""oHef52JefSuBAehm0gTDxRYasOE"",
          ""id"": ""UgyXP3-YpITxt4BU3XR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Спасибо, хороший выпуск!"",
            ""textOriginal"": ""Спасибо, хороший выпуск!"",
            ""authorDisplayName"": ""Виталий Журавель"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhQ8oKEf0KhPFOz3Q2wvbvAUk5FNULj5IowRw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC1UdXA5SoEf2Y8FUFFwVbRw"",
            ""authorChannelId"": {
                    ""value"": ""UC1UdXA5SoEf2Y8FUFFwVbRw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:42:45Z"",
            ""updatedAt"": ""2021-01-02T08:42:45Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""M8xQLdWAHOnJxHrWVzUZk0z-tro"",
      ""id"": ""UgziZGsU6q_4-udkTat4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""dE5AXDBo3OtWI9n58ua-Zu6rAx0"",
          ""id"": ""UgziZGsU6q_4-udkTat4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""В  Дениса цирк на кассе)"",
            ""textOriginal"": ""В  Дениса цирк на кассе)"",
            ""authorDisplayName"": ""Wayrine %?"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhWDVNUFZKHNv0GcvGvoCnNBshaLwdfQt6MoBIXSQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCiA2B3rGUTdO4iwEcAba5kQ"",
            ""authorChannelId"": {
                    ""value"": ""UCiA2B3rGUTdO4iwEcAba5kQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:38:34Z"",
            ""updatedAt"": ""2021-01-02T08:38:59Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""JTtFCK3KyKKYp5Fc2GbnNAQmYpo"",
      ""id"": ""UgxMnzje99ilFSRMf8R4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""yQ8d4ZNgmere2ZoT9BynPC7hwwQ"",
          ""id"": ""UgxMnzje99ilFSRMf8R4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Познавательно,спасибо!"",
            ""textOriginal"": ""Познавательно,спасибо!"",
            ""authorDisplayName"": ""Mart Martin"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhX__1ObFlOiDQe8gQJRtIYinKO1wCULGKh3A=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCp6ym39t-HhkfXoU0w_Mq2g"",
            ""authorChannelId"": {
                    ""value"": ""UCp6ym39t-HhkfXoU0w_Mq2g""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:34:44Z"",
            ""updatedAt"": ""2021-01-02T08:34:44Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""HecZJVREvqjxBZhOq07Nik8Uz0w"",
      ""id"": ""Ugzu5YH0iknVg2XeF194AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""JljWfTFK83vjr_P42R_Dt63PN34"",
          ""id"": ""Ugzu5YH0iknVg2XeF194AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Саги агонь. Заходит формат. Спасибо"",
            ""textOriginal"": ""Саги агонь. Заходит формат. Спасибо"",
            ""authorDisplayName"": ""Gasymov System - Построение отдела продаж"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngx7L5AzBJj0RFp8RMbn899hkDEDPCHbzROu2yCyg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCXcIJTwox4vFizpKlhud2vA"",
            ""authorChannelId"": {
                    ""value"": ""UCXcIJTwox4vFizpKlhud2vA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:32:31Z"",
            ""updatedAt"": ""2021-01-02T08:32:31Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""pzRgfI5AwmTrTIMFPMgGN26AU_s"",
      ""id"": ""UgxRbMrqFTzlaDPmhMB4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""TVQDeMmpz-AWgyZOvRXoXHQHe5w"",
          ""id"": ""UgxRbMrqFTzlaDPmhMB4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, давай пруфы, как так получается что в мусульманских странах женщина как предмет интерьера? А? Мне с детства вливают в башку что женщина это сверх создание, которое нужно беречь и всё ей отдавать, а мать вообще на вершине всех ценностей. Это все стереотипы, такие утверждения рождают ложные представления о нашей религии и про нас."",
            ""textOriginal"": ""Денис, давай пруфы, как так получается что в мусульманских странах женщина как предмет интерьера? А? Мне с детства вливают в башку что женщина это сверх создание, которое нужно беречь и всё ей отдавать, а мать вообще на вершине всех ценностей. Это все стереотипы, такие утверждения рождают ложные представления о нашей религии и про нас."",
            ""authorDisplayName"": ""War Cry"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjxVeW2OYuuHua0AGihptCP7HgtbHdIBhbkmSUWCQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCM_kK_Ir0f0XIm6r_Lm6O1Q"",
            ""authorChannelId"": {
                    ""value"": ""UCM_kK_Ir0f0XIm6r_Lm6O1Q""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T08:31:52Z"",
            ""updatedAt"": ""2021-01-02T08:31:52Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""rogjvxoV1M33VOJjsP2Y71KXzZ8"",
      ""id"": ""Ugz-h0XiyiKgvskk_sV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""UAXtMJkH2ntZKJeekAJV2P3MRRA"",
          ""id"": ""Ugz-h0XiyiKgvskk_sV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=34m33s\""\u003e34:33\u003c/a\u003e Если грамотно зарегулировать капитализм, получится социализм \u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=35m17s\""\u003e35:17\u003c/a\u003e Смешно) Как зарегулировали бы, если рабочая сила в США гораздо дороже, чем в азии? Ну в детройте зарегулировали бы, и европейский автопром обошёл бы в конкурентной гонке. А всю планету зарегулировать - получается социализм, но у тебя на него аллергия. \u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=36m31s\""\u003e36:31\u003c/a\u003e Война чёрных против белых - это не классовый конфликт. Это увод от классового конфликта к рассовому. Классовый конфликт, это когда рабочие (вне зависимости от цвета кожи и дохода) поднимают на вилы владельцев производств."",
            ""textOriginal"": ""34:33 Если грамотно зарегулировать капитализм, получится социализм 35:17 Смешно) Как зарегулировали бы, если рабочая сила в США гораздо дороже, чем в азии? Ну в детройте зарегулировали бы, и европейский автопром обошёл бы в конкурентной гонке. А всю планету зарегулировать - получается социализм, но у тебя на него аллергия. 36:31 Война чёрных против белых - это не классовый конфликт. Это увод от классового конфликта к рассовому. Классовый конфликт, это когда рабочие (вне зависимости от цвета кожи и дохода) поднимают на вилы владельцев производств."",
            ""authorDisplayName"": ""shai huludov"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngc_dKNZNOetKbLExKEVhm0nIqBY1YAj8vtw9Ei=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC4sLDMxpfXURK36_SiouYdA"",
            ""authorChannelId"": {
                    ""value"": ""UC4sLDMxpfXURK36_SiouYdA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:31:41Z"",
            ""updatedAt"": ""2021-01-02T08:38:24Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""WVkjqM2ktSVZmFNgUIs69YHCVSE"",
      ""id"": ""UgwadFoW57AhyNqKCBl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""XMkytxZPg4JS7xixqHoQUxPn8yw"",
          ""id"": ""UgwadFoW57AhyNqKCBl4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Так она не жирная,так 50% женщин выглядят)"",
            ""textOriginal"": ""Так она не жирная,так 50% женщин выглядят)"",
            ""authorDisplayName"": ""Андрей Сергеевич"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwng_sRjWUTiWXdBI1qY9Kl2pYQwzdoFriHuYAooI=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UChR11qtv5_E_yXTpO-osUBA"",
            ""authorChannelId"": {
                    ""value"": ""UChR11qtv5_E_yXTpO-osUBA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:31:14Z"",
            ""updatedAt"": ""2021-01-02T08:31:14Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""aGEMVRYZ60BeTUYgu-QNtgTTLiA"",
      ""id"": ""UgzNR9KQ9qQ3XArDgrJ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""pIQHsXIewD6gS9g5oDvV9hFIH10"",
          ""id"": ""UgzNR9KQ9qQ3XArDgrJ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Интересно было бы послушать тему про биометрию (Хорошие , плохие стороны)как действуют  поддельные паспорта в мире;"",
            ""textOriginal"": ""Интересно было бы послушать тему про биометрию (Хорошие , плохие стороны)как действуют  поддельные паспорта в мире;"",
            ""authorDisplayName"": ""Бадин Руслан"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjefB1qVemfYDLPyqMTl3lqfCCnRH53xKL1_V6a=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCbJOfNjPQDUG8RI1CAHQ9DA"",
            ""authorChannelId"": {
                    ""value"": ""UCbJOfNjPQDUG8RI1CAHQ9DA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:29:36Z"",
            ""updatedAt"": ""2021-01-02T08:29:36Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""KaO9C00pR2uZGRD_9yLzjUZEYXQ"",
      ""id"": ""UgzETmHuDw-JwqymNY94AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""NI8pxkh3z4gX6S6gdeT06sH9aWQ"",
          ""id"": ""UgzETmHuDw-JwqymNY94AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Спасибо Денис Владимирович!"",
            ""textOriginal"": ""Спасибо Денис Владимирович!"",
            ""authorDisplayName"": ""Нутрициолог Ольга Кустова"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniJoConB8vJ1nufTDT8B0bNq04SCIuKOTCzRrTlvA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCnxZofOJy5J_Okl_P2DFbsw"",
            ""authorChannelId"": {
                    ""value"": ""UCnxZofOJy5J_Okl_P2DFbsw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T08:29:25Z"",
            ""updatedAt"": ""2021-01-02T08:29:25Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""NkrKz6eel7d4FaXF6817U0N4JkM"",
      ""id"": ""Ugy1uaNkiF5zTvFIXZ94AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""qpPSxH_Y2GeBA4O58fZ4Kl-b7Sk"",
          ""id"": ""Ugy1uaNkiF5zTvFIXZ94AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, спасибо за новую, интересную рубрику и за все твои труды в целом👍🏼\u003cbr /\u003eС новым годом и да прибудет с тобой сила💪"",
            ""textOriginal"": ""Денис, спасибо за новую, интересную рубрику и за все твои труды в целом👍🏼\nС новым годом и да прибудет с тобой сила💪"",
            ""authorDisplayName"": ""Dmitry Fomenko"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngJZJu5xzyDydbVnY6ddbJr5EsnH5XYmq-vErkQyg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCLWuW4WHGM3jFtUz6MeN3WQ"",
            ""authorChannelId"": {
                    ""value"": ""UCLWuW4WHGM3jFtUz6MeN3WQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T08:28:39Z"",
            ""updatedAt"": ""2021-01-02T08:30:33Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""NiarbfuhH6nGfwy8tTEndkOkY68"",
      ""id"": ""UgwMHaHvkSDesEZ7o6J4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""WOtwk6GCAUmAU-FUoPjiEYedJFI"",
          ""id"": ""UgwMHaHvkSDesEZ7o6J4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Ну как больше никаких изменений кроме лишнего веса?она черная,по моему формируються определенные трэнды"",
            ""textOriginal"": ""Ну как больше никаких изменений кроме лишнего веса?она черная,по моему формируються определенные трэнды"",
            ""authorDisplayName"": ""Владимир Тамаровский"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjGAEem5o70WWwon8SdTXwyFLRs1cIecmwhgbfviA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCJRTZcOd1COuj5kCsQAyLjA"",
            ""authorChannelId"": {
                    ""value"": ""UCJRTZcOd1COuj5kCsQAyLjA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T08:24:38Z"",
            ""updatedAt"": ""2021-01-02T08:24:38Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""wXMpYf8WZyVdZWr6wuenYNekkig"",
      ""id"": ""UgzkoEojmRyqCsq1AF94AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""rZb05Ddg6ln7K5XGlpkB0nOA0mw"",
          ""id"": ""UgzkoEojmRyqCsq1AF94AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Только начал качаться. А тут такое. 😂😂😂"",
            ""textOriginal"": ""Только начал качаться. А тут такое. 😂😂😂"",
            ""authorDisplayName"": ""Yura Kim"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngYj9EJJEY1byGkYgKvKV6zp_1VxizzfWXktI0A5A=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCE6Ob0vzbJlQ3wFY-Ie2bVA"",
            ""authorChannelId"": {
                    ""value"": ""UCE6Ob0vzbJlQ3wFY-Ie2bVA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:23:16Z"",
            ""updatedAt"": ""2021-01-02T08:23:16Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""aBKGaCfrZLmgd0RAcQwB5eyA3jY"",
      ""id"": ""Ugw379VubtQHx-aswxV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""sqRrcWntslDwTQ4c6VaEuxUhmfo"",
          ""id"": ""Ugw379VubtQHx-aswxV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, прочитай книгу Михаила Наумова &quot;Мужской клуб&quot;. Там с твоей любимой позиции гормонов шикарно всё объясняется. Просто есть, на мой взгляд некоторые неточности в твоём посыле о мотивации женщин."",
            ""textOriginal"": ""Денис, прочитай книгу Михаила Наумова \""Мужской клуб\"". Там с твоей любимой позиции гормонов шикарно всё объясняется. Просто есть, на мой взгляд некоторые неточности в твоём посыле о мотивации женщин."",
            ""authorDisplayName"": ""Илья Харченко"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhHyCSMAqn3UBnsJxOuYFn_2-Hix_Eh3ZU-7kvU6w=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCvoibeTfV_t-xRWeWtcYWTQ"",
            ""authorChannelId"": {
                    ""value"": ""UCvoibeTfV_t-xRWeWtcYWTQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:23:02Z"",
            ""updatedAt"": ""2021-01-02T08:23:02Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""pRMX1dj5Cr4SrAR-B7q2W53wVYE"",
      ""id"": ""Ugzpf-c_JVEX_fxLWzd4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""SGPoFxIunVND1lI-lQ3NYLoFi34"",
          ""id"": ""Ugzpf-c_JVEX_fxLWzd4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Дэн бро ,зашёл в инсту кельвин не нашёл свиней"",
            ""textOriginal"": ""Дэн бро ,зашёл в инсту кельвин не нашёл свиней"",
            ""authorDisplayName"": ""твой бро"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniMV0AVIUFpOnou4PyJyal6aH44xeNANq1YLCPCsA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCTFmAd1wtH9c-bQ1j0P88vA"",
            ""authorChannelId"": {
                    ""value"": ""UCTFmAd1wtH9c-bQ1j0P88vA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:19:51Z"",
            ""updatedAt"": ""2021-01-02T08:19:51Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""kZFEmysllr5qvVEx721QV_U36wc"",
      ""id"": ""UgwetgmbutbbvRH_ujp4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""tXMHXM6f8IpjOXkitLzfW6UwzEQ"",
          ""id"": ""UgwetgmbutbbvRH_ujp4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Т.е. там можно динамить бап говоря, что она не достаточно жирная? 🤔"",
            ""textOriginal"": ""Т.е. там можно динамить бап говоря, что она не достаточно жирная? 🤔"",
            ""authorDisplayName"": ""Alexander N"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh5lOLJmICjQA4OsnP7QJVdsxRFzvisM4NPcwlC8w=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCoJM6t9_g3WKbJxLXg32gRw"",
            ""authorChannelId"": {
                    ""value"": ""UCoJM6t9_g3WKbJxLXg32gRw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:18:32Z"",
            ""updatedAt"": ""2021-01-02T08:18:32Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""cfgzYLqP4gqVz3l2MBiCmnthjh4"",
      ""id"": ""UgxdCOpiDDSzmSKNPUp4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""e6sGDSjdRELHyJuc4g3ocSfMbmI"",
          ""id"": ""UgxdCOpiDDSzmSKNPUp4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Скорее бы уже Денчик ещё пару каналов сделал, чтобы можно было меньше ждать новых видосов"",
            ""textOriginal"": ""Скорее бы уже Денчик ещё пару каналов сделал, чтобы можно было меньше ждать новых видосов"",
            ""authorDisplayName"": ""Алексей Васильев"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnj9PV7sOzg6DHg_61M9ixNil0-Sbrvij34dzk1g=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCFHA7nm1q9UgFGRtP-bNeHQ"",
            ""authorChannelId"": {
                    ""value"": ""UCFHA7nm1q9UgFGRtP-bNeHQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T08:16:59Z"",
            ""updatedAt"": ""2021-01-02T08:16:59Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""-4HUmsES2GbeECBvORWeTfClSvg"",
      ""id"": ""UgzRV_pL7MV-QXhUbqx4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""cJXQIOxQ_pO3GO4rnBplQdSCAXc"",
          ""id"": ""UgzRV_pL7MV-QXhUbqx4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Сидел и кивал, поедая тортик, когда Денис говорил про ожирение👍🏻😁"",
            ""textOriginal"": ""Сидел и кивал, поедая тортик, когда Денис говорил про ожирение👍🏻😁"",
            ""authorDisplayName"": ""Dmitry Fomenko"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngJZJu5xzyDydbVnY6ddbJr5EsnH5XYmq-vErkQyg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCLWuW4WHGM3jFtUz6MeN3WQ"",
            ""authorChannelId"": {
                    ""value"": ""UCLWuW4WHGM3jFtUz6MeN3WQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 30,
            ""publishedAt"": ""2021-01-02T08:16:26Z"",
            ""updatedAt"": ""2021-01-02T08:16:26Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Z6yMrMrbCLdCQznG_af8c6XQdUY"",
      ""id"": ""Ugzbp0ITTAHS8zhlV0h4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""-neRUgO_xQH1aEr1_ew38z0IvoE"",
          ""id"": ""Ugzbp0ITTAHS8zhlV0h4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Кельвин бомба"",
            ""textOriginal"": ""Кельвин бомба"",
            ""authorDisplayName"": ""твой бро"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniMV0AVIUFpOnou4PyJyal6aH44xeNANq1YLCPCsA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCTFmAd1wtH9c-bQ1j0P88vA"",
            ""authorChannelId"": {
                    ""value"": ""UCTFmAd1wtH9c-bQ1j0P88vA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:11:06Z"",
            ""updatedAt"": ""2021-01-02T08:11:06Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""GW7D6woabGM5bupvwMQy-ht08Z0"",
      ""id"": ""Ugz2ziAPsu2m3QVulHp4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""x_yOkuh4sxWBq6s8_3ViqSTnIbI"",
          ""id"": ""Ugz2ziAPsu2m3QVulHp4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""про остальное слышал, а вот про проверку на честность прямо зашло!"",
            ""textOriginal"": ""про остальное слышал, а вот про проверку на честность прямо зашло!"",
            ""authorDisplayName"": ""Александр Ган"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwni8k_XH1Bql4ohnjf3TQUB6Es_WfZ6SIMNW8A=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC6ndgJYIyyYWDccLg-dNY8A"",
            ""authorChannelId"": {
                    ""value"": ""UC6ndgJYIyyYWDccLg-dNY8A""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:10:56Z"",
            ""updatedAt"": ""2021-01-02T08:10:56Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""-N87QUhDkP7hgB3HoBN-QBSCMNo"",
      ""id"": ""Ugx1CC69BD0wG1cGOOR4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""1Qnn9_W5ssUwvO6jblFwwo07Uvk"",
          ""id"": ""Ugx1CC69BD0wG1cGOOR4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Пропик во мне"",
            ""textOriginal"": ""Пропик во мне"",
            ""authorDisplayName"": ""твой бро"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniMV0AVIUFpOnou4PyJyal6aH44xeNANq1YLCPCsA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCTFmAd1wtH9c-bQ1j0P88vA"",
            ""authorChannelId"": {
                    ""value"": ""UCTFmAd1wtH9c-bQ1j0P88vA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:10:07Z"",
            ""updatedAt"": ""2021-01-02T08:10:07Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""I5gkS-Gk1fkG_a3wloUvZE5-Wqw"",
      ""id"": ""UgxMRZ5eIO_kemDkRwt4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""WFMKDmcDKhGk1AMKcvpXcYFN9vI"",
          ""id"": ""UgxMRZ5eIO_kemDkRwt4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Видео Дениса действуют как гипноз, невозможно оторваться от просмотра. Спасибо тебе огромное, настолько ценный контент большая редкость.\u003cbr /\u003eМожно больше видео связанных с человеческой психологией, работой мозга, поведением? \u003cbr /\u003eСтавьте лайки, чтобы денчик увидел коммент."",
            ""textOriginal"": ""Видео Дениса действуют как гипноз, невозможно оторваться от просмотра. Спасибо тебе огромное, настолько ценный контент большая редкость.\nМожно больше видео связанных с человеческой психологией, работой мозга, поведением? \nСтавьте лайки, чтобы денчик увидел коммент."",
            ""authorDisplayName"": ""Александр Кузьмин"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjZ6tmXv344MVNKDLhHnBK5YXpnJfC38f7wn6BH=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC5r06dnyxP6AuGzl7Nakm0g"",
            ""authorChannelId"": {
                    ""value"": ""UC5r06dnyxP6AuGzl7Nakm0g""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 54,
            ""publishedAt"": ""2021-01-02T08:07:21Z"",
            ""updatedAt"": ""2021-01-02T16:46:21Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""U7BA4JIT3pmJcePz3VjsCG3ZgaU"",
      ""id"": ""UgxMae-epWAN6on1NSV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""YOKEt4KYOmxIFvJzaZpYLdanrps"",
          ""id"": ""UgxMae-epWAN6on1NSV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""С Новым годом, Денис! Спасибо огромное за твой труд. Эти бы знания мне да так эдак лет на сорок раньше. Сложилась бы совсем другая жизнь, но и так довольно не плохо."",
            ""textOriginal"": ""С Новым годом, Денис! Спасибо огромное за твой труд. Эти бы знания мне да так эдак лет на сорок раньше. Сложилась бы совсем другая жизнь, но и так довольно не плохо."",
            ""authorDisplayName"": ""Подхалюзин Сергей"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnglb3NsdJ7qEa1XfAahqnYkjnaj6-hpSiTtnA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCPnLxNc_hO1nBlNRGzKkPFg"",
            ""authorChannelId"": {
                    ""value"": ""UCPnLxNc_hO1nBlNRGzKkPFg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T08:05:14Z"",
            ""updatedAt"": ""2021-01-02T08:05:14Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""NpXt_iDCh-JQESpf4NoGNFnRKgg"",
      ""id"": ""UgzI4mDtV-tcQC1aS4J4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""W0RlMtBqo4kjOwe77A4f5iw0WXw"",
          ""id"": ""UgzI4mDtV-tcQC1aS4J4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денис, приветствую. Я посмотрел не все твои ролики с основами, меня это не заинтересовало. Это грех для адептов Основания?"",
            ""textOriginal"": ""Денис, приветствую. Я посмотрел не все твои ролики с основами, меня это не заинтересовало. Это грех для адептов Основания?"",
            ""authorDisplayName"": ""Vitaliy Samarcev"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh0XYi8_Gg-aLfuwYxMhPu_77WnfcVWxmAzMg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCDa807fNxTEIyNNWWwNg3NQ"",
            ""authorChannelId"": {
                    ""value"": ""UCDa807fNxTEIyNNWWwNg3NQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:05:05Z"",
            ""updatedAt"": ""2021-01-02T08:05:05Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""R1ui6w730sZDsug_AtSLT8QvWc0"",
      ""id"": ""UgxJkixu7zCySXl4Ejl4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""8wf1o4g8FdtDnQDQm1hsI7Y5Tvg"",
          ""id"": ""UgxJkixu7zCySXl4Ejl4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""\u003ca href=\""https://www.youtube.com/watch?v=sNeBFnYAAXY&amp;t=1m00s\""\u003e1:00\u003c/a\u003e Денис, ну о чем ты. Конечно мужчины не смотрят на внешность, главное душа! И уж у второй душа наверняка намного чище и прекраснее."",
            ""textOriginal"": ""1:00 Денис, ну о чем ты. Конечно мужчины не смотрят на внешность, главное душа! И уж у второй душа наверняка намного чище и прекраснее."",
            ""authorDisplayName"": ""Supernova"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwni2FTEls69De7L4p41jcpYEl17kLU_l6hAobSuO-Q=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCPwnrE2O8xHlMjyefqmJlFw"",
            ""authorChannelId"": {
                    ""value"": ""UCPwnrE2O8xHlMjyefqmJlFw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T08:01:18Z"",
            ""updatedAt"": ""2021-01-02T08:01:18Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""lI6zCYmEx-teK8GE3NZj47fqo6c"",
      ""id"": ""Ugz6OW-OVbeSjGKqLsN4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""p81ubHiMFqsh9-tBz2GstXHwfEI"",
          ""id"": ""Ugz6OW-OVbeSjGKqLsN4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Омичи объединяемся, телеграмм @osnovanie_omsk"",
            ""textOriginal"": ""Омичи объединяемся, телеграмм @osnovanie_omsk"",
            ""authorDisplayName"": ""slavinol"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngvXKS9mU9AaLh41sGnNeqg6tH4TfwXdQ-Q2iL8=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCC2WXTPE_pmfrIhIK86KH8Q"",
            ""authorChannelId"": {
                    ""value"": ""UCC2WXTPE_pmfrIhIK86KH8Q""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T07:56:06Z"",
            ""updatedAt"": ""2021-01-02T07:56:06Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""OierocUb3GL7D-ZIFqM8sa4R7bU"",
      ""id"": ""Ugwxfm5_NjWH0q90M054AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""KYXvSx-_jyM0v9yJBpjJFU0xmmw"",
          ""id"": ""Ugwxfm5_NjWH0q90M054AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денчик, расскажи про питание, какие продукты покупать ? Где покупать ? Как по мне это большая проблема найти здоровые продукты в магазине"",
            ""textOriginal"": ""Денчик, расскажи про питание, какие продукты покупать ? Где покупать ? Как по мне это большая проблема найти здоровые продукты в магазине"",
            ""authorDisplayName"": ""Роман Сом"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhs5dAAdkAN6g13IbYNN-VXhNb2Lgs7GN3eSogF=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCePoithWA-bPspR-TbLAydw"",
            ""authorChannelId"": {
                    ""value"": ""UCePoithWA-bPspR-TbLAydw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 19,
            ""publishedAt"": ""2021-01-02T07:53:06Z"",
            ""updatedAt"": ""2021-01-02T07:53:06Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""zfmIUshg6DJumIOmhJ3N4oxM4TE"",
      ""id"": ""UgyrQ-hSXr2ekdbMSiZ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""HONA0DoJZwoBbwX6TvuaJCyC7OI"",
          ""id"": ""UgyrQ-hSXr2ekdbMSiZ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Не, Денчик, тут ты не прав насчёт равенства. Историцки совок был на передовой по равноправию и все плюшки для женщин, за которые борются на Западе сейчас, были у нас про Софье Власьевне. Но. Всё это было затеяно ради высвобождения тудовых ресурсов, чтобы вытащить женщину из семьи и поставить к станку.  Отсюда и перекос в правах Мэ и Жо. Если уж делать равноправие - то во всём. Пусть и в декрете каждый родитель будет ОБЯЗАН сидеть по очереди. Пусть в случае развода имущество делится пропорционально вкладу в его приобретение. Пусть вместо алиментов будет поочерёдное проживание ребёнка. Пусть в общественном транспорте перестанут объявлять &quot;уступвйте места пожилым, инвалидам и женщинам&quot;. Эта штука называется &quot;эгалитаризм&quot;.\u003cbr /\u003e\u003cbr /\u003eА бодипозитив начался с хорошей идеи: перестать обвинять людей за то, чего они НЕ МОГУТ исправить: отрастить ногу, победить врождённую болезнь. Только как часто бывает, инициатиыу перехватили рессентименты."",
            ""textOriginal"": ""Не, Денчик, тут ты не прав насчёт равенства. Историцки совок был на передовой по равноправию и все плюшки для женщин, за которые борются на Западе сейчас, были у нас про Софье Власьевне. Но. Всё это было затеяно ради высвобождения тудовых ресурсов, чтобы вытащить женщину из семьи и поставить к станку.  Отсюда и перекос в правах Мэ и Жо. Если уж делать равноправие - то во всём. Пусть и в декрете каждый родитель будет ОБЯЗАН сидеть по очереди. Пусть в случае развода имущество делится пропорционально вкладу в его приобретение. Пусть вместо алиментов будет поочерёдное проживание ребёнка. Пусть в общественном транспорте перестанут объявлять \""уступвйте места пожилым, инвалидам и женщинам\"". Эта штука называется \""эгалитаризм\"".\n\nА бодипозитив начался с хорошей идеи: перестать обвинять людей за то, чего они НЕ МОГУТ исправить: отрастить ногу, победить врождённую болезнь. Только как часто бывает, инициатиыу перехватили рессентименты."",
            ""authorDisplayName"": ""dasdrandulett"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhmo5D_Y4nZBhxvtsI7yjTaNU9fl4sQ_WwwlA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC9EysEcnam4kKE1XWSoljbw"",
            ""authorChannelId"": {
                    ""value"": ""UC9EysEcnam4kKE1XWSoljbw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T07:52:04Z"",
            ""updatedAt"": ""2021-01-02T07:52:04Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 2,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""l-oOchLdXoMIJGU90mqt-vAR2LU"",
      ""id"": ""UgzBa3zTeJ1SvF1e46J4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""BtM5jgCsrIBrZ6ut-hgs25pa2aI"",
          ""id"": ""UgzBa3zTeJ1SvF1e46J4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Кашляит чей-та. Нипарядок"",
            ""textOriginal"": ""Кашляит чей-та. Нипарядок"",
            ""authorDisplayName"": ""CoH710"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngWGWa6ix-fN2jPEZMX7q8BOg0Kslyf-ZTyF5VOSQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCxtGclWr2xShlwCpcxAv3ZA"",
            ""authorChannelId"": {
                    ""value"": ""UCxtGclWr2xShlwCpcxAv3ZA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T07:51:15Z"",
            ""updatedAt"": ""2021-01-02T07:51:15Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""lqlifmrBrqUQ7JSaOyuR0-ArWsc"",
      ""id"": ""Ugwcq1kqQ4DaT-V0Hpp4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""PNwZ-Q2eyF9H9nfV8e1ZsluMR5g"",
          ""id"": ""Ugwcq1kqQ4DaT-V0Hpp4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""\u003cb\u003eВ мутной воде кто-то делает гешефт! Тема полноты была уже прокачана в фильме &quot;Москва 2017&quot;.\u003c/b\u003e"",
            ""textOriginal"": ""*В мутной воде кто-то делает гешефт! Тема полноты была уже прокачана в фильме \""Москва 2017\"".*"",
            ""authorDisplayName"": ""Политическое детство"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjmRFXEzd7cw0Ww0V1ZR8TcSKLvw3iX3zq6IPxT=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCD87Lie0FfrhWBNMLDzgL5Q"",
            ""authorChannelId"": {
                    ""value"": ""UCD87Lie0FfrhWBNMLDzgL5Q""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 4,
            ""publishedAt"": ""2021-01-02T07:36:03Z"",
            ""updatedAt"": ""2021-01-02T07:44:45Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""SBfMkwpSZOW_V_QTkAeE7oV0FtY"",
      ""id"": ""UgwOBTZ27W8bLoPmVPV4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""_A8gJKG9OA6xj1aTs2e8xP_1ctY"",
          ""id"": ""UgwOBTZ27W8bLoPmVPV4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Сейчас идёт не развитие общества, а деградация, технологии развиваются , но общество деградирует."",
            ""textOriginal"": ""Сейчас идёт не развитие общества, а деградация, технологии развиваются , но общество деградирует."",
            ""authorDisplayName"": ""сергей сахаров"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh7TVF_SQJY-op5hvukkFIwppIENpURruJkeWNkbA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC5Yt5bOK9ElqrxgxMo74yXg"",
            ""authorChannelId"": {
                    ""value"": ""UC5Yt5bOK9ElqrxgxMo74yXg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T07:33:50Z"",
            ""updatedAt"": ""2021-01-02T07:33:50Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 2,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""kPIpTZY7S4NuuuYm2fYgzFH-elg"",
      ""id"": ""UgyrFN-Kf6Y3s62kZdF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""6oh74GKJ_50xZl-QVERkBXblDfI"",
          ""id"": ""UgyrFN-Kf6Y3s62kZdF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""С новым годом Денис, во многом ты прав но есть моменты в которых ты не Копенгаген, просто не все темы ты изучал, не всё тебя касается так как других. Я про тему с мд, и то мд не однороден и таки мд является реакцией на политику государств и феминизм."",
            ""textOriginal"": ""С новым годом Денис, во многом ты прав но есть моменты в которых ты не Копенгаген, просто не все темы ты изучал, не всё тебя касается так как других. Я про тему с мд, и то мд не однороден и таки мд является реакцией на политику государств и феминизм."",
            ""authorDisplayName"": ""сергей сахаров"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh7TVF_SQJY-op5hvukkFIwppIENpURruJkeWNkbA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC5Yt5bOK9ElqrxgxMo74yXg"",
            ""authorChannelId"": {
                    ""value"": ""UC5Yt5bOK9ElqrxgxMo74yXg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T07:32:36Z"",
            ""updatedAt"": ""2021-01-02T07:32:36Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 5,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""4D3pK31C-8WurfzebAkv0mbBZbQ"",
      ""id"": ""UgyjIh31-XvXsJv0yl94AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""FjvqX00kXA3xoDc_UAiMaKaVISU"",
          ""id"": ""UgyjIh31-XvXsJv0yl94AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Денчик почитай устав эгалитарного мужского движения . Ты же юрист по образованию почитай манифест."",
            ""textOriginal"": ""Денчик почитай устав эгалитарного мужского движения . Ты же юрист по образованию почитай манифест."",
            ""authorDisplayName"": ""Азамат Татаров"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjqQrupNGxUU0zSoeQCa-AbBHIo1iA-QvtgvneU=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCVEBcV850XpoHgV4A18uNDA"",
            ""authorChannelId"": {
                    ""value"": ""UCVEBcV850XpoHgV4A18uNDA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T07:31:07Z"",
            ""updatedAt"": ""2021-01-02T07:31:07Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 2,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""AoP_sOPgj8fdGuZh7UGUI-gZ9xs"",
      ""id"": ""Ugx1dS4QGkbvGx5IluJ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""ahar-4eI0dBOrhDhYLvKllWUJtA"",
          ""id"": ""Ugx1dS4QGkbvGx5IluJ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Душевно поздравил😊😊\u003cbr /\u003eСпасибо Денис, и тебе я желаю достигануть всего что ты хочешь реализовать в этом году"",
            ""textOriginal"": ""Душевно поздравил😊😊\nСпасибо Денис, и тебе я желаю достигануть всего что ты хочешь реализовать в этом году"",
            ""authorDisplayName"": ""sevenalieks"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjqpPuoCmSO7MCeOlWzj4EjW7yrDpZNAM3FZ-mbhA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCUxhMzdMXj_PFCRhO-HGjhQ"",
            ""authorChannelId"": {
                    ""value"": ""UCUxhMzdMXj_PFCRhO-HGjhQ""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T07:30:21Z"",
            ""updatedAt"": ""2021-01-02T07:30:21Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Ye15HtWC3kKDsOc9KACvy5J3css"",
      ""id"": ""UgxXLyoI6yEFdavihbN4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""kP_ggtkT9Y8EXoZHu8OoDef46wQ"",
          ""id"": ""UgxXLyoI6yEFdavihbN4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""вон даже у Дениса в голове изменения , уже боится женщину назвать женщиной -все у него девушки )))"",
            ""textOriginal"": ""вон даже у Дениса в голове изменения , уже боится женщину назвать женщиной -все у него девушки )))"",
            ""authorDisplayName"": ""Семён"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhA5XlkaNuhx--fmpOnV3uI0iUdxN2NPgAkiV_3JA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC9jVOvChlB9FO6Xsbu2FiHA"",
            ""authorChannelId"": {
                    ""value"": ""UC9jVOvChlB9FO6Xsbu2FiHA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 6,
            ""publishedAt"": ""2021-01-02T07:28:51Z"",
            ""updatedAt"": ""2021-01-02T07:28:51Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 3,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""Hgw3P_qV1YunsxvLysImqSlKwGE"",
      ""id"": ""UgxY5B5IrY0g6lMMa894AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""MumOK8013Dx1N7fySsoBJv0rTIQ"",
          ""id"": ""UgxY5B5IrY0g6lMMa894AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Спасибо) и тебя с новым годом)\u003cbr /\u003eРасскажи про тактики вложения денег в крипту, например как тактика&quot; маленькой старушки&quot; от да Винчи и его друга."",
            ""textOriginal"": ""Спасибо) и тебя с новым годом)\nРасскажи про тактики вложения денег в крипту, например как тактика\"" маленькой старушки\"" от да Винчи и его друга."",
            ""authorDisplayName"": ""Архангел Гавриил"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjBaRsqKBOU1wJYmdDqn77Oqw3m4xRp9nzizD5izw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCMKGw3N55K_gGnNiM1biejA"",
            ""authorChannelId"": {
                    ""value"": ""UCMKGw3N55K_gGnNiM1biejA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T07:28:39Z"",
            ""updatedAt"": ""2021-01-02T07:28:39Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""wydqiYg6vJkZtZLurjolRvQAT6s"",
      ""id"": ""UgzK2o_8_zBk7GC_EBZ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""j_8wBHzRYtvaLbT-7zPt7Z-16rE"",
          ""id"": ""UgzK2o_8_zBk7GC_EBZ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Жруны атакуют !"",
            ""textOriginal"": ""Жруны атакуют !"",
            ""authorDisplayName"": ""Yevhen Shevchenko"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnh6PboVytWarxYdWktAIp3QB3fc0zKtou9K8r6Hxg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCLul9A1fj7IQzutzRJxdk_Q"",
            ""authorChannelId"": {
                    ""value"": ""UCLul9A1fj7IQzutzRJxdk_Q""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T07:26:54Z"",
            ""updatedAt"": ""2021-01-02T07:26:54Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""_MmLeETlDuN_3-ryVeb8YOzmpEg"",
      ""id"": ""UgzM5JTVLF1ulQ2S9ip4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""X01glcPEudrNfYvSW7nPT8K9Z8U"",
          ""id"": ""UgzM5JTVLF1ulQ2S9ip4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Если все поровну, то зачем женщине мужчина"",
            ""textOriginal"": ""Если все поровну, то зачем женщине мужчина"",
            ""authorDisplayName"": ""Irina Irina"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngyedWZOLnRySQFJrQCpt2OFaafFNAsa8iaZBfJnw=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCVW0HOJm68H2ehbXvNa_hIg"",
            ""authorChannelId"": {
                    ""value"": ""UCVW0HOJm68H2ehbXvNa_hIg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 1,
            ""publishedAt"": ""2021-01-02T07:25:21Z"",
            ""updatedAt"": ""2021-01-02T07:25:34Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 3,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""ZpqkK7Yk5SGAOgalCOEDC35FhjQ"",
      ""id"": ""UgzI-Q14KIKks6Lsc7x4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""swXCbVXJ92vGgdqPOHuYyc6-Lk0"",
          ""id"": ""UgzI-Q14KIKks6Lsc7x4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Там еще и цвет кожи поменялся с трендами мировыми) не удивлюсь если ещё заявят что &quot;модель&quot; относится к каким нибудь меньшинствам"",
            ""textOriginal"": ""Там еще и цвет кожи поменялся с трендами мировыми) не удивлюсь если ещё заявят что \""модель\"" относится к каким нибудь меньшинствам"",
            ""authorDisplayName"": ""Дмитрий Голиков"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniLiqscDKPylETx57P5aogPGktcHes3OslnGQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCEfBaeup8TCUB6w05Nx_fBg"",
            ""authorChannelId"": {
                    ""value"": ""UCEfBaeup8TCUB6w05Nx_fBg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 6,
            ""publishedAt"": ""2021-01-02T07:25:18Z"",
            ""updatedAt"": ""2021-01-02T07:46:44Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 1,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""eokkc68mvl5jLzxHaUGEsjlWDIY"",
      ""id"": ""UgycM_KSePeZZOnf_GZ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""Gdw1hzcI3jd4TadDq3MdpyabbIE"",
          ""id"": ""UgycM_KSePeZZOnf_GZ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""calvin klein уже не тот)"",
            ""textOriginal"": ""calvin klein уже не тот)"",
            ""authorDisplayName"": ""Олег Брейн"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniC1C1jFly-bpMvWRrbjROIoZP3eVcUkuOo2OJo=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCZTcxawhQIKGQQpqvDeq_QA"",
            ""authorChannelId"": {
                    ""value"": ""UCZTcxawhQIKGQQpqvDeq_QA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T07:22:38Z"",
            ""updatedAt"": ""2021-01-02T07:22:38Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""1jb0s_wkGGsYO2lh2N243PgwDWQ"",
      ""id"": ""UgxvjarQsrbC1eI0rXJ4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""y5vdQS1mQPKPszVBlCGZ8Ezan34"",
          ""id"": ""UgxvjarQsrbC1eI0rXJ4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Спасибо, желаю и тебе Денис видеть в остальных не только плохое и радовать нас очередными проектами"",
            ""textOriginal"": ""Спасибо, желаю и тебе Денис видеть в остальных не только плохое и радовать нас очередными проектами"",
            ""authorDisplayName"": ""bar Nik"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhJuxb_qPVp1MWRrfITs2h4U75UBE0ILHlYoQ=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UC8psTZENJn_dqKVs7Ev-2XA"",
            ""authorChannelId"": {
                    ""value"": ""UC8psTZENJn_dqKVs7Ev-2XA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T07:19:14Z"",
            ""updatedAt"": ""2021-01-02T07:19:14Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""K4dzmCieTh-DpnV87_TFuKKTqKg"",
      ""id"": ""UgyqwA4LbWjLTubjqDF4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""OpG2B3QHYiE6xqRQpOb1kirt-f0"",
          ""id"": ""UgyqwA4LbWjLTubjqDF4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""В ссср так и жили\u003cbr /\u003eРакеты в космос запускали\u003cbr /\u003eА жили в бараках \u003cbr /\u003eИ ходили по нужде на улицу"",
            ""textOriginal"": ""В ссср так и жили\nРакеты в космос запускали\nА жили в бараках \nИ ходили по нужде на улицу"",
            ""authorDisplayName"": ""создатель ежей"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhm96-_ylGHlf2l0Yeb-_nHnmxGPzQGj0Z0-w=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCRqC1iFiDPhBTnpKLaeNOGg"",
            ""authorChannelId"": {
                    ""value"": ""UCRqC1iFiDPhBTnpKLaeNOGg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T07:19:09Z"",
            ""updatedAt"": ""2021-01-02T07:19:09Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 2,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""PEPEqWZUGexf5sBchWsDBnFUfy4"",
      ""id"": ""UgzqLdF3xfrGBXa5Tr14AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""V0DxQJzxiQJSX2Df5qFPxw-eMuc"",
          ""id"": ""UgzqLdF3xfrGBXa5Tr14AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Кто нибудь может ответить: Что такое боди - негатив???"",
            ""textOriginal"": ""Кто нибудь может ответить: Что такое боди - негатив???"",
            ""authorDisplayName"": ""Denis Korogodov"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnhokQbffZP2NTMesAeS75XZTwpltOWqrbf-vYSg004=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCgeaECgDiGiRM-_TBU-Q9Nw"",
            ""authorChannelId"": {
                    ""value"": ""UCgeaECgDiGiRM-_TBU-Q9Nw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T07:18:47Z"",
            ""updatedAt"": ""2021-01-02T07:18:47Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 3,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""3KgqQm0at1uOj_ofcbRWEenSvZY"",
      ""id"": ""Ugwe1t5q7_Ttwb8aBNx4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""OkA2pjUfXI1HnsOvMhMlOXnwA8A"",
          ""id"": ""Ugwe1t5q7_Ttwb8aBNx4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Ставь лайк если помнишь отсылку к:\u003cbr /\u003e &quot;Главное - это ДУША И ЛЮЦИФЕРУ"",
            ""textOriginal"": ""Ставь лайк если помнишь отсылку к:\n \""Главное - это ДУША И ЛЮЦИФЕРУ"",
            ""authorDisplayName"": ""Eвгений Золотов"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwng5ZcnYKxEib4jRxy9kVbO9CamiizmQrtEf8g=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCXFbetMtGw31MaoFknBc4Bg"",
            ""authorChannelId"": {
                    ""value"": ""UCXFbetMtGw31MaoFknBc4Bg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T07:13:55Z"",
            ""updatedAt"": ""2021-01-02T07:13:55Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""5y8ayvGgIWOU8YbPtfxU7UWZJvM"",
      ""id"": ""UgwntWePgy5VWiRL6_B4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""dsHxS6DfHz9LXUnB5Iuo011XNt0"",
          ""id"": ""UgwntWePgy5VWiRL6_B4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Привет, Денис!:)"",
            ""textOriginal"": ""Привет, Денис!:)"",
            ""authorDisplayName"": ""Arcad"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwniCLBNp8_G-uDxipReHpTFLBnyNflX9VIUWOoAWvA=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCbkE_-cXh2KupTnkZwEPSPA"",
            ""authorChannelId"": {
                    ""value"": ""UCbkE_-cXh2KupTnkZwEPSPA""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 0,
            ""publishedAt"": ""2021-01-02T07:12:02Z"",
            ""updatedAt"": ""2021-01-02T07:12:02Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""gVt91FwhmFuiiHh4Z9D_128GV8A"",
      ""id"": ""Ugy8QL7ueBe7U0p-c_F4AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""q33bolUwxJOjtefG46e4NVnegII"",
          ""id"": ""Ugy8QL7ueBe7U0p-c_F4AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Не согласен, это не развитие общества, это закат западной цивилизации. Идёт массированная пропаганда трансов, феминизма и цель - снижение рождаемости. Нельзя обмануть природу, общество где мужчина и женщина равны будет покорённым обществом, где мужчина главный, т.к. тестостерон это гормон завоевателей. Римская империя была построена патриархальным обществом мужественных римлян, но когда мужчины стали неженками и общество сменилось на матриархат, то пришли Германские племена и уничтожили Рим.\u003cbr /\u003eТак же будет и с западной цивилизацией. Исламская семья делает 3-5 детей, семья западных ценностей всего лишь одного. Простая математика. Западные страны выраждаются, одно из самых популярных имён в Лондоне - Мухаммед. Нельзя обмануть биологические роли хомо сапиенсов. Женщина - хранительница очага, Мужчина - воин. Смена ролей или их уравнивание обязательно приведёт к тому, что общество выродится и на его место придёт другое."",
            ""textOriginal"": ""Не согласен, это не развитие общества, это закат западной цивилизации. Идёт массированная пропаганда трансов, феминизма и цель - снижение рождаемости. Нельзя обмануть природу, общество где мужчина и женщина равны будет покорённым обществом, где мужчина главный, т.к. тестостерон это гормон завоевателей. Римская империя была построена патриархальным обществом мужественных римлян, но когда мужчины стали неженками и общество сменилось на матриархат, то пришли Германские племена и уничтожили Рим.\nТак же будет и с западной цивилизацией. Исламская семья делает 3-5 детей, семья западных ценностей всего лишь одного. Простая математика. Западные страны выраждаются, одно из самых популярных имён в Лондоне - Мухаммед. Нельзя обмануть биологические роли хомо сапиенсов. Женщина - хранительница очага, Мужчина - воин. Смена ролей или их уравнивание обязательно приведёт к тому, что общество выродится и на его место придёт другое."",
            ""authorDisplayName"": ""Max Zabolotskiy"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwngafdiMTSK92fr9M9NqgxNfJyrcq09E9OLpMW52=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCMNLkB4yvhaMOyIXuJwjFgw"",
            ""authorChannelId"": {
                    ""value"": ""UCMNLkB4yvhaMOyIXuJwjFgw""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 8,
            ""publishedAt"": ""2021-01-02T07:11:57Z"",
            ""updatedAt"": ""2021-01-02T07:11:57Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
},
    {
    ""kind"": ""youtube#commentThread"",
      ""etag"": ""hO69nBUqZjlKrLhbSewd5RresBM"",
      ""id"": ""UgwkvJRlZJHzue0SdY54AaABAg"",
      ""snippet"": {
        ""videoId"": ""sNeBFnYAAXY"",
        ""topLevelComment"": {
            ""kind"": ""youtube#comment"",
          ""etag"": ""KqZ0m3h-UiacU_iir_hVRZk6OAM"",
          ""id"": ""UgwkvJRlZJHzue0SdY54AaABAg"",
          ""snippet"": {
                ""videoId"": ""sNeBFnYAAXY"",
            ""textDisplay"": ""Сибирь смотрит."",
            ""textOriginal"": ""Сибирь смотрит."",
            ""authorDisplayName"": ""Sibirien auf Deutsch"",
            ""authorProfileImageUrl"": ""https://yt3.ggpht.com/ytc/AAUvwnjvzZAIoDQO12E7OMHCN6A927AagSzyQuep1kuvhg=s48-c-k-c0xffffffff-no-rj-mo"",
            ""authorChannelUrl"": ""http://www.youtube.com/channel/UCU7p9LG2B4tyZqeIFW6-Fhg"",
            ""authorChannelId"": {
                    ""value"": ""UCU7p9LG2B4tyZqeIFW6-Fhg""
            },
            ""canRate"": true,
            ""viewerRating"": ""none"",
            ""likeCount"": 2,
            ""publishedAt"": ""2021-01-02T07:11:37Z"",
            ""updatedAt"": ""2021-01-02T07:11:37Z""
          }
        },
        ""canReply"": true,
        ""totalReplyCount"": 0,
        ""isPublic"": true
      }
}
  ]
}
";
        public static string videosIdsResponce = @"{
                    ""kind"": ""youtube#searchListResponse"",
                    ""etag"": ""fqM_58mAB9oDnuZgMaI0Whx0qPk"",
                    ""prevPageToken"": ""CAsQAQ"",
                    ""regionCode"": ""RU"",
                    ""pageInfo"": {
                        ""totalResults"": 22,
                        ""resultsPerPage"": 11
                    },
                     ""items"": [{
                        ""kind"": ""youtube#searchResult"",
                        ""etag"": ""Oc9Ue12Ft4Gjzvpd4GASk1wqaGI"",
                        ""id"": {
                            ""kind"": ""youtube#video"",
                            ""videoId"": ""XZjVzzdNKlE""
                        }},
                    {
                    ""kind"": ""youtube#searchResult"",
                    ""etag"": ""eU7JXXqAJnu8IQM2-N2te_SiwkM"",
                    ""id"": {
                        ""kind"": ""youtube#video"",
        ""videoId"": ""K4QWP9pn_4M""
      }
                },
    {
                    ""kind"": ""youtube#searchResult"",
      ""etag"": ""uBR9a-PkrfUj8B3MvlEQ-RQQBRQ"",
      ""id"": {
                        ""kind"": ""youtube#video"",
        ""videoId"": ""gcxA_8ZTHk0""
      }
                },
    {
                    ""kind"": ""youtube#searchResult"",
      ""etag"": ""U-pzZIW7rjzV8VN11AMMM4NWq4c"",
      ""id"": {
                        ""kind"": ""youtube#video"",
        ""videoId"": ""7iPX0PUCgBg""
      }
                },
    {
                    ""kind"": ""youtube#searchResult"",
      ""etag"": ""NPlyb7YA6b7OCm7BEs_m8LtMPfM"",
      ""id"": {
                        ""kind"": ""youtube#channel"",
        ""channelId"": ""UCXOzPAwI8ChKpGjRXE4E7ew""
      }
                },
    {
                    ""kind"": ""youtube#searchResult"",
      ""etag"": ""iW_rgM9TO3s5Lw3N7-bFjLiktL4"",
      ""id"": {
                        ""kind"": ""youtube#video"",
        ""videoId"": ""q55kHb-jdCc""
      }
                },
    {
                    ""kind"": ""youtube#searchResult"",
      ""etag"": ""WnvpfstlhtPvxZL6FEJqaUkUh3Y"",
      ""id"": {
                        ""kind"": ""youtube#video"",
        ""videoId"": ""r2Tdhc0HCwA""
      }
                },
    {
                    ""kind"": ""youtube#searchResult"",
      ""etag"": ""LgBDt6BHu2SFHGw8HfF21GS0Pzc"",
      ""id"": {
                        ""kind"": ""youtube#video"",
        ""videoId"": ""Yu19whr7EgU""
      }
                },
    {
                    ""kind"": ""youtube#searchResult"",
      ""etag"": ""rbKQXHMT6I1bwDGRyBv-JHtfz2I"",
      ""id"": {
                        ""kind"": ""youtube#video"",
        ""videoId"": ""jO4ZR5cdfD0""
      }
                },
    {
                    ""kind"": ""youtube#searchResult"",
      ""etag"": ""FdkcOWEG_hJ5oRg41WhhOobq4Xo"",
      ""id"": {
                        ""kind"": ""youtube#video"",
        ""videoId"": ""gAnII8QoXiI""
      }
                },
    {
                    ""kind"": ""youtube#searchResult"",
      ""etag"": ""vPfKuaoMwzp9Vetk5GRXBBTahKI"",
      ""id"": {
                        ""kind"": ""youtube#video"",
        ""videoId"": ""sNeBFnYAAXY""
      }
                }
  ]
}
";
    }
}
