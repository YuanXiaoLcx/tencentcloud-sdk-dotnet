/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitImageTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 输入分析对象内容
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// 输入分析对象类型，picture_url:图片地址，vod_url:视频地址，live_url：直播地址
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 任务控制选项
        /// </summary>
        [JsonProperty("Functions")]
        public ImageTaskFunction Functions{ get; set; }

        /// <summary>
        /// 光照标准列表
        /// </summary>
        [JsonProperty("LightStandardSet")]
        public LightStandard[] LightStandardSet{ get; set; }

        /// <summary>
        /// 抽帧的时间间隔，单位毫秒，默认值1000。
        /// </summary>
        [JsonProperty("FrameInterval")]
        public long? FrameInterval{ get; set; }

        /// <summary>
        /// 查询人员库列表
        /// </summary>
        [JsonProperty("LibrarySet")]
        public string[] LibrarySet{ get; set; }

        /// <summary>
        /// 最大的视频长度，单位毫秒，默认值为两小时
        /// </summary>
        [JsonProperty("MaxVideoDuration")]
        public long? MaxVideoDuration{ get; set; }

        /// <summary>
        /// 人脸识别中的相似度阈值，默认值为0.89
        /// </summary>
        [JsonProperty("SimThreshold")]
        public float? SimThreshold{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamObj(map, prefix + "Functions.", this.Functions);
            this.SetParamArrayObj(map, prefix + "LightStandardSet.", this.LightStandardSet);
            this.SetParamSimple(map, prefix + "FrameInterval", this.FrameInterval);
            this.SetParamArraySimple(map, prefix + "LibrarySet.", this.LibrarySet);
            this.SetParamSimple(map, prefix + "MaxVideoDuration", this.MaxVideoDuration);
            this.SetParamSimple(map, prefix + "SimThreshold", this.SimThreshold);
        }
    }
}

