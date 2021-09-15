namespace GLC.Integration.Cargowiseone.LINC.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://TestBTFF.FlatFileSchema1",@"LINCCSV")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"LINCCSV"})]
    public sealed class LincFLAT : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://TestBTFF.FlatFileSchema1"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://TestBTFF.FlatFileSchema1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
      <b:schemaInfo standard=""Flat File"" codepage=""65001"" default_pad_char="" "" pad_char_type=""char"" count_positions_by_byte=""false"" parser_optimization=""speed"" lookahead_depth=""3"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" allow_early_termination=""false"" early_terminate_optional_fields=""false"" allow_message_breakup_of_infix_root=""true"" compile_parse_tables=""false"" root_reference=""LINCCSV"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""LINCCSV"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" child_delimiter_type=""hex"" child_delimiter=""0xD 0xA"" child_order=""postfix"" sequence_number=""1"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:annotation>
          <xs:appinfo>
            <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
          </xs:appinfo>
        </xs:annotation>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LINCRecord"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""delimited"" child_delimiter_type=""char"" child_delimiter=""|"" child_order=""infix"" sequence_number=""1"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
            </xs:appinfo>
          </xs:annotation>
          <xs:complexType>
            <xs:sequence>
              <xs:annotation>
                <xs:appinfo>
                  <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
                </xs:appinfo>
              </xs:annotation>
              <xs:element minOccurs=""0"" name=""GLCOrder"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo structure=""delimited"" child_delimiter_type=""char"" child_delimiter="","" child_order=""infix"" sequence_number=""1"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:sequence>
                    <xs:annotation>
                      <xs:appinfo>
                        <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
                      </xs:appinfo>
                    </xs:annotation>
                    <xs:element minOccurs=""0"" name=""ORDERHEADER"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""1"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""CLIENTCODE"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""2"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TRANSPORTCODE"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""3"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""CONSIGNEENAME"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""4"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""CONSIGNEEADDRESS1"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""5"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""CONSIGNEECITY"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""6"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""CONSIGNEESTATE"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""7"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""CONSIGNEEPOCODE"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""8"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""CONSIGNEECOUNTRY"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""9"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""ORDERNUMBER"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""10"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""CUSTOMERREF"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""11"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TRANSPORTREF"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""12"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""REQUIREDDATE"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""13"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TOTALUNITS"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""14"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""OrderLine"">
                <xs:annotation>
                  <xs:appinfo>
                    <b:recordInfo structure=""delimited"" child_delimiter_type=""char"" child_delimiter="","" child_order=""infix"" sequence_number=""2"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" />
                  </xs:appinfo>
                </xs:annotation>
                <xs:complexType>
                  <xs:sequence>
                    <xs:annotation>
                      <xs:appinfo>
                        <groupInfo sequence_number=""0"" xmlns=""http://schemas.microsoft.com/BizTalk/2003"" />
                      </xs:appinfo>
                    </xs:annotation>
                    <xs:element minOccurs=""0"" name=""ORDERLINE"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""1"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""LINENUMBER"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""2"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""PRODUCTCODE"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""3"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""PACKS"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""4"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""PACKSQUANTITY"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""5"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""PACKSQUANTITYUNIT"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""6"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child7"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""7"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child8"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""8"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child9"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""9"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child10"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""10"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child11"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""11"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child12"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""12"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child13"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""13"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child14"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""14"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child15"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""15"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child16"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""16"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child17"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""17"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child18"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""18"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child19"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""19"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child20"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""20"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child21"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""21"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child22"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""22"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""TestRoot_Child1_Child2_Child23"" type=""xs:string"">
                      <xs:annotation>
                        <xs:appinfo>
                          <b:fieldInfo justification=""left"" sequence_number=""23"" />
                        </xs:appinfo>
                      </xs:annotation>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public LincFLAT() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "LINCCSV";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
