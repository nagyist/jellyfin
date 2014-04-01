﻿using System.Xml.Serialization;
using MediaBrowser.Controller.Dlna;

namespace MediaBrowser.Dlna.Profiles
{
    [XmlRoot("Profile")]
    public class SonyBravia2013Profile : DefaultProfile
    {
        public SonyBravia2013Profile()
        {
            Name = "Sony Bravia (2013)";

            Identification = new DeviceIdentification
            {
                FriendlyName = @"KDL-\d{2}[WR][5689]\d{2}A.*",
                Manufacturer = "Sony",

                Headers = new[]
                {
                    new HttpHeaderInfo
                    {
                        Name = "X-AV-Client-Info",
                        Value = @".*KDL-\d{2}[WR][5689]\d{2}A.*",
                        Match = HeaderMatchType.Regex
                    }
                }
            };

            ModelName = "Windows Media Player Sharing";
            ModelNumber = "3.0";
            ModelUrl = "http://www.microsoft.com/";
            Manufacturer = "Microsoft Corporation";
            ManufacturerUrl = "http://www.microsoft.com/";
            SonyAggregationFlags = "10";

            TranscodingProfiles = new[]
            {
                new TranscodingProfile
                {
                    Container = "mp3",
                    Type = DlnaProfileType.Audio
                },
                new TranscodingProfile
                {
                    Container = "ts",
                    VideoCodec = "h264",
                    AudioCodec = "ac3,aac",
                    Type = DlnaProfileType.Video,
                    EnableMpegtsM2TsMode = true
                },
                new TranscodingProfile
                {
                    Container = "jpeg",
                    Type = DlnaProfileType.Photo
                }
            };

            DirectPlayProfiles = new[]
            {
                new DirectPlayProfile
                {
                    Container = "ts",
                    VideoCodec = "h264",
                    AudioCodec = "ac3,eac3,aac,mp3",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "ts",
                    VideoCodec = "mpeg2video",
                    AudioCodec = "mp3,mp2",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "mp4",
                    VideoCodec = "h264,mpeg4",
                    AudioCodec = "ac3,eac3,aac,mp3,mp2",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "mov",
                    VideoCodec = "h264,mpeg4,mjpeg",
                    AudioCodec = "ac3,eac3,aac,mp3,mp2",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "mkv",
                    VideoCodec = "h264,mpeg4,vp8",
                    AudioCodec = "ac3,eac3,aac,mp3,mp2,pcm,vorbis",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "avi",
                    VideoCodec = "mpeg4",
                    AudioCodec = "ac3,eac3,mp3",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "avi",
                    VideoCodec = "mjpeg",
                    AudioCodec = "pcm",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "mpeg",
                    VideoCodec = "mpeg2video,mpeg1video",
                    AudioCodec = "mp3,mp2",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "asf",
                    VideoCodec = "wmv2,wmv3,vc1",
                    AudioCodec = "wmav2,wmapro,wmavoice",
                    Type = DlnaProfileType.Video
                },
                new DirectPlayProfile
                {
                    Container = "mp3",
                    AudioCodec = "mp3",
                    Type = DlnaProfileType.Audio
                },
                new DirectPlayProfile
                {
                    Container = "mp4",
                    AudioCodec = "aac",
                    Type = DlnaProfileType.Audio
                },
                new DirectPlayProfile
                {
                    Container = "wav",
                    AudioCodec = "pcm",
                    Type = DlnaProfileType.Audio
                },
                new DirectPlayProfile
                {
                    Container = "asf",
                    AudioCodec = "wmav2,wmapro,wmavoice",
                    Type = DlnaProfileType.Audio
                },
                new DirectPlayProfile
                {
                    Container = "jpeg",
                    Type = DlnaProfileType.Photo
                }
            };

            ContainerProfiles = new[]
            {
                new ContainerProfile
                {
                    Type = DlnaProfileType.Photo,

                    Conditions = new []
                    {
                        new ProfileCondition
                        {
                            Condition = ProfileConditionType.LessThanEqual,
                            Property = ProfileConditionValue.Width,
                            Value = "1920"
                        },
                        new ProfileCondition
                        {
                            Condition = ProfileConditionType.LessThanEqual,
                            Property = ProfileConditionValue.Height,
                            Value = "1080"
                        }
                    }
                }
            };

            ResponseProfiles = new[]
            {
                new ResponseProfile
                {
                    Container = "ts",
                    VideoCodec="h264",
                    AudioCodec="ac3,aac,mp3",
                    MimeType = "video/vnd.dlna.mpeg-tts",
                    OrgPn="AVC_TS_HD_24_AC3_T,AVC_TS_HD_50_AC3_T,AVC_TS_HD_60_AC3_T,AVC_TS_HD_EU_T",
                    Type = DlnaProfileType.Video
                },

                new ResponseProfile
                {
                    Container = "ts",
                    VideoCodec="h264",
                    AudioCodec="ac3,aac,mp3",
                    MimeType = "video/mpeg",
                    OrgPn="AVC_TS_HD_24_AC3_ISO,AVC_TS_HD_50_AC3_ISO,AVC_TS_HD_60_AC3_ISO,AVC_TS_HD_EU_ISO",
                    Type = DlnaProfileType.Video
                },

                new ResponseProfile
                {
                    Container = "ts",
                    VideoCodec="h264",
                    AudioCodec="ac3,aac,mp3",
                    MimeType = "video/vnd.dlna.mpeg-tts",
                    OrgPn="AVC_TS_HD_24_AC3,AVC_TS_HD_50_AC3,AVC_TS_HD_60_AC3,AVC_TS_HD_EU",
                    Type = DlnaProfileType.Video
                },

                new ResponseProfile
                {
                    Container = "ts",
                    VideoCodec="mpeg2video",
                    MimeType = "video/vnd.dlna.mpeg-tts",
                    OrgPn="MPEG_TS_SD_EU,MPEG_TS_SD_NA,MPEG_TS_SD_KO",
                    Type = DlnaProfileType.Video
                },

                new ResponseProfile
                {
                    Container = "mpeg",
                    VideoCodec="mpeg1video,mpeg2video",
                    MimeType = "video/mpeg",
                    OrgPn="MPEG_PS_NTSC,MPEG_PS_PAL",
                    Type = DlnaProfileType.Video
                }
            };


            CodecProfiles = new[]
            {
                new CodecProfile
                {
                    Type = CodecType.Video,

                    Conditions = new []
                    {
                        new ProfileCondition
                        {
                            Condition = ProfileConditionType.LessThanEqual,
                            Property = ProfileConditionValue.Width,
                            Value = "1920"
                        },
                        new ProfileCondition
                        {
                            Condition = ProfileConditionType.LessThanEqual,
                            Property = ProfileConditionValue.Height,
                            Value = "1080"
                        }
                    }
                }
            };
        }
    }
}
