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

    public class SubmitAudioTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 音频源的语言，默认0为英文，1为中文
        /// </summary>
        [JsonProperty("Lang")]
        public long? Lang{ get; set; }

        /// <summary>
        /// 音频URL。客户请求为URL方式时必须带此字段指名音频的url。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 语音编码类型 1:pcm
        /// </summary>
        [JsonProperty("VoiceEncodeType")]
        public long? VoiceEncodeType{ get; set; }

        /// <summary>
        /// 语音文件类型 1:raw, 2:wav, 3:mp3（三种格式目前仅支持16k采样率16bit）
        /// </summary>
        [JsonProperty("VoiceFileType")]
        public long? VoiceFileType{ get; set; }

        /// <summary>
        /// 功能开关列表，表示是否需要打开相应的功能，返回相应的信息
        /// </summary>
        [JsonProperty("Functions")]
        public Function Functions{ get; set; }

        /// <summary>
        /// 课堂标识符
        /// </summary>
        [JsonProperty("ClassId")]
        public string ClassId{ get; set; }

        /// <summary>
        /// 身份，1：老师 2：学生
        /// </summary>
        [JsonProperty("Identity")]
        public long? Identity{ get; set; }

        /// <summary>
        /// 识别词库名列表，评估过程使用这些词汇库中的词汇进行词汇使用行为分析
        /// </summary>
        [JsonProperty("VocabLibNameList")]
        public string[] VocabLibNameList{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Lang", this.Lang);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "VoiceEncodeType", this.VoiceEncodeType);
            this.SetParamSimple(map, prefix + "VoiceFileType", this.VoiceFileType);
            this.SetParamObj(map, prefix + "Functions.", this.Functions);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "Identity", this.Identity);
            this.SetParamArraySimple(map, prefix + "VocabLibNameList.", this.VocabLibNameList);
        }
    }
}

