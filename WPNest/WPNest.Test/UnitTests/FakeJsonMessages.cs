﻿namespace WPNest.Test.UnitTests {
	public static class FakeJsonMessages {

		public static string UserId {
			get { return "137516"; }
		}

		public static string GetStatusResult {
			get { return GetStatusResultBase
				.Replace("|||ISAWAY|||", "false")
				.Replace("|||TEMPTYPE|||", "\"heat\""); 
			}
		}

		public static string GetStatusResultAwayMode {
			get { return GetStatusResultBase
				.Replace("|||ISAWAY|||", "true")
				.Replace("|||TEMPTYPE|||", "\"heat\""); 
			}
		}

		public static string GetStatusResultTempRangeMode {
			get { return GetStatusResultBase
				.Replace("|||ISAWAY|||", "true")
				.Replace("|||TEMPTYPE|||", "\"range\""); 
			}
		}

		public static string GetSharedStatusResult {
			get { return GetSharedStatusResultBase
				.Replace("|||TEMPTYPE|||", "\"heat\""); 
			}
		}

		public static string GetSharedStatusResultTempRangeMode {
			get { return GetSharedStatusResultBase
				.Replace("|||TEMPTYPE|||", "\"range\""); 
			}
		}

		public static string GetStructureStatusResult {
			get { return GetStructureStatusResultBase; }
		}

		private const string GetStatusResultBase = @"{
   ""metadata"":{
      ""02AA01AB41120QVD"":{
         ""$version"":-2074012793,
         ""$timestamp"":1352684422000,
         ""last_connection"":1352684422503,
         ""last_ip"":""24.93.205.58""
      }
   },
   ""track"":{
      ""02AA01AB41120QVD"":{
         ""$version"":481243315,
         ""$timestamp"":1352684431744,
         ""online"":true,
         ""last_connection"":1352684431744,
         ""last_ip"":""24.93.205.58""
      }
   },
   ""user_settings"":{
      ""137516"":{
         ""$version"":1633472277,
         ""$timestamp"":1352234497355,
         ""email_verified"":true,
         ""tos_accepted_version"":1319500800000,
         ""receive_marketing_emails"":true,
         ""receive_nest_emails"":true,
         ""receive_support_emails"":true,
         ""max_structures"":2,
         ""max_thermostats"":10,
         ""max_thermostats_per_structure"":10,
         ""tos_minimum_version"":1319500800000,
         ""tos_current_version"":1319500800000,
         ""lang"":""en_US""
      }
   },
   ""structure"":{
      ""3cf5fec0-2852-11e2-949b-12313941fd7d"":{
         ""$version"":-693251188,
         ""$timestamp"":1352640008000,
         ""location"":""44039"",
         ""renovation_date"":""2010"",
         ""country_code"":""US"",
         ""away_timestamp"":1352640000,
         ""away"":|||ISAWAY|||,
         ""house_type"":""family"",
         ""postal_code"":""44039"",
         ""name"":"""",
         ""creation_time"":1352234444972,
         ""num_thermostats"":""1"",
         ""devices"":[
            ""device.02AA01AB41120QVD""
         ],
         ""user"":""user.137516"",
         ""away_setter"":0
      }
   },
   ""link"":{
      ""02AA01AB41120QVD"":{
         ""$version"":1119989028,
         ""$timestamp"":1352234535000,
         ""structure"":""structure.3cf5fec0-2852-11e2-949b-12313941fd7d""
      }
   },
   ""device"":{
      ""02AA01AB41120QVD"":{
         ""$version"":-93105611,
         ""$timestamp"":1352684427000,
         ""heatpump_setback_active"":false,
         ""emer_heat_enable"":false,
         ""local_ip"":""172.16.42.2"",
         ""switch_system_off"":false,
         ""away_temperature_high"":24.444,
         ""cooling_source"":""electric"",
         ""temperature_lock_high_temp"":22.222,
         ""leaf_threshold_cool"":0.0,
         ""note_codes"":[

         ],
         ""fan_cooling_state"":false,
         ""heater_source"":""gas"",
         ""compressor_lockout_leaf"":-17.8,
         ""has_x3_heat"":false,
         ""target_humidity_enabled"":false,
         ""heat_x3_source"":""gas"",
         ""alt_heat_delivery"":""forced-air"",
         ""has_x2_heat"":false,
         ""fan_mode"":""auto"",
         ""rssi"":64.0,
         ""emer_heat_delivery"":""forced-air"",
         ""heatpump_savings"":""off"",
         ""pin_y2_description"":""none"",
         ""filter_reminder_enabled"":false,
         ""capability_level"":3.0,
         ""schedule_learning_reset"":false,
         ""has_x2_cool"":false,
         ""ob_orientation"":""O"",
         ""hvac_pins"":""W1,Y1,C,Rc,G"",
         ""range_enable"":true,
         ""auto_away_enable"":true,
         ""dual_fuel_breakpoint_override"":""none"",
         ""lower_safety_temp_enabled"":true,
         ""has_fan"":true,
         ""dehumidifier_state"":false,
         ""nlclient_state"":"""",
         ""emer_heat_source"":""electric"",
         ""heatpump_ready"":false,
         ""available_locales"":""en_US,fr_CA,es_US"",
         ""current_version"":""3.0.2"",
         ""learning_state"":""steady"",
         ""pin_ob_description"":""none"",
         ""pin_rh_description"":""none"",
         ""has_alt_heat"":false,
         ""pin_y1_description"":""cool"",
         ""humidifier_state"":false,
         ""backplate_serial_number"":""02BA01AB42120A0D"",
         ""has_x2_alt_heat"":false,
         ""leaf_threshold_heat"":20.049,
         ""heat_x3_delivery"":""forced-air"",
         ""has_emer_heat"":false,
         ""learning_mode"":true,
         ""leaf_learning"":""ready"",
         ""has_aux_heat"":false,
         ""aux_heat_source"":""electric"",
         ""backplate_bsl_info"":""BSL"",
         ""alt_heat_x2_source"":""gas"",
         ""pin_c_description"":""power"",
         ""humidifier_type"":""unknown"",
         ""pin_w2aux_description"":""none"",
         ""country_code"":""US"",
         ""heat_x2_delivery"":""forced-air"",
         ""target_humidity"":35.0,
         ""lower_safety_temp"":4.444,
         ""cooling_x2_source"":""electric"",
         ""equipment_type"":""electric"",
         ""heat_pump_aux_threshold"":10.0,
         ""alt_heat_x2_delivery"":""forced-air"",
         ""heat_pump_comp_threshold"":-31.5,
         ""learning_days_completed_cool"":0,
         ""backplate_bsl_version"":""2.1"",
         ""current_schedule_mode"":""HEAT"",
         ""hvac_wires"":""Heat,Cool,Fan,Common Wire,Rc"",
         ""leaf"":true,
         ""type"":""TBD"",
         ""pin_g_description"":""fan"",
         ""click_sound"":""on"",
         ""away_temperature_low_enabled"":true,
         ""aux_heat_delivery"":""forced-air"",
         ""heat_pump_comp_threshold_enabled"":false,
         ""preconditioning_ready"":true,
         ""has_dehumidifier"":false,
         ""fan_cooling_enabled"":true,
         ""leaf_away_high"":28.88,
         ""fan_cooling_readiness"":""not ready"",
         ""temperature_scale"":""F"",
         ""device_locale"":""en_US"",
         ""error_code"":"""",
         ""battery_level"":3.945,
         ""preconditioning_active"":false,
         ""away_temperature_high_enabled"":false,
         ""learning_days_completed_heat"":7,
         ""upper_safety_temp_enabled"":false,
         ""pin_star_description"":""none"",
         ""preconditioning_enabled"":false,
         ""current_humidity"":44,
         ""dual_fuel_breakpoint"":-1.0,
         ""postal_code"":""44039"",
         ""alt_heat_source"":""gas"",
         ""backplate_mono_version"":""4.0.6"",
         ""aux_lockout_leaf"":10.0,
         ""has_heat_pump"":false,
         ""heater_delivery"":""forced-air"",
         ""away_temperature_low"":10.0,
         ""auto_away_reset"":false,
         ""radiant_control_enabled"":false,
         ""temperature_lock"":false,
         ""dehumidifier_type"":""unknown"",
         ""time_to_target_training"":""ready"",
         ""upper_safety_temp"":35.0,
         ""target_time_confidence"":1.0,
         ""pin_w1_description"":""heat"",
         ""temperature_lock_low_temp"":20.0,
         ""forced_air"":true,
         ""temperature_lock_pin_hash"":"""",
         ""leaf_type"":1,
         ""backplate_mono_info"":""TFE (BP_D2) 4.0.6 (root@bamboo) 2012-10-18 17:09:55"",
         ""has_dual_fuel"":false,
         ""learning_time"":556,
         ""creation_time"":1352233297794,
         ""has_humidifier"":false,
         ""learning_days_completed_range"":0,
         ""leaf_schedule_delta"":1.11,
         ""user_brightness"":""medium"",
         ""leaf_away_low"":20.893,
         ""pin_rc_description"":""power"",
         ""serial_number"":""02AA01AB41120QVD"",
         ""mac_address"":""18b4300672c3"",
         ""heat_x2_source"":""gas"",
         ""time_to_target"":0,
         ""backplate_model"":""Backplate-2.5"",
         ""model_version"":""Display-2.6"",
         ""heat_pump_aux_threshold_enabled"":true
      }
   },
   ""schedule"":{
      ""02AA01AB41120QVD"":{
         ""$version"":1715660084,
         ""$timestamp"":1352610834000,
         ""days"":{
            ""3"":{
               ""3"":{
                  ""touched_by"":1,
                  ""time"":64800,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":21.284,
                  ""type"":""HEAT"",
                  ""touched_at"":1352437224
               },
               ""2"":{
                  ""touched_by"":1,
                  ""time"":58500,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":22.097,
                  ""type"":""HEAT"",
                  ""touched_at"":1352350824
               },
               ""1"":{
                  ""touched_by"":1,
                  ""time"":27000,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":20.893,
                  ""type"":""HEAT"",
                  ""touched_at"":1352523624
               },
               ""0"":{
                  ""touched_by"":1,
                  ""time"":0,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""continuation"",
                  ""temp"":21.284,
                  ""type"":""HEAT"",
                  ""touched_at"":1352610556
               }
            },
            ""2"":{
               ""3"":{
                  ""touched_by"":1,
                  ""time"":64800,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":21.284,
                  ""type"":""HEAT"",
                  ""touched_at"":1352437224
               },
               ""2"":{
                  ""touched_by"":1,
                  ""time"":58500,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":22.097,
                  ""type"":""HEAT"",
                  ""touched_at"":1352350824
               },
               ""1"":{
                  ""touched_by"":1,
                  ""time"":27000,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":20.893,
                  ""type"":""HEAT"",
                  ""touched_at"":1352523624
               },
               ""0"":{
                  ""touched_by"":1,
                  ""time"":0,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""continuation"",
                  ""temp"":21.284,
                  ""type"":""HEAT"",
                  ""touched_at"":1352610556
               }
            },
            ""1"":{
               ""3"":{
                  ""touched_by"":1,
                  ""time"":64800,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":21.284,
                  ""type"":""HEAT"",
                  ""touched_at"":1352437224
               },
               ""2"":{
                  ""touched_by"":1,
                  ""time"":58500,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":22.097,
                  ""type"":""HEAT"",
                  ""touched_at"":1352350824
               },
               ""1"":{
                  ""touched_by"":1,
                  ""time"":27000,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":20.893,
                  ""type"":""HEAT"",
                  ""touched_at"":1352523624
               },
               ""0"":{
                  ""touched_by"":1,
                  ""time"":0,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""continuation"",
                  ""temp"":21.284,
                  ""type"":""HEAT"",
                  ""touched_at"":1352610556
               }
            },
            ""0"":{
               ""3"":{
                  ""touched_by"":1,
                  ""time"":64800,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":21.284,
                  ""type"":""HEAT"",
                  ""touched_at"":1352437224
               },
               ""2"":{
                  ""touched_by"":1,
                  ""time"":58500,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":22.097,
                  ""type"":""HEAT"",
                  ""touched_at"":1352350824
               },
               ""1"":{
                  ""touched_by"":1,
                  ""time"":27000,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":20.893,
                  ""type"":""HEAT"",
                  ""touched_at"":1352523624
               },
               ""0"":{
                  ""touched_by"":1,
                  ""time"":0,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""continuation"",
                  ""temp"":21.159,
                  ""type"":""HEAT"",
                  ""touched_at"":1352610556
               }
            },
            ""6"":{
               ""3"":{
                  ""touched_by"":1,
                  ""time"":63900,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":21.159,
                  ""type"":""HEAT"",
                  ""touched_at"":1352264424
               },
               ""2"":{
                  ""touched_by"":1,
                  ""time"":60300,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":22.715,
                  ""type"":""HEAT"",
                  ""touched_at"":1352264424
               },
               ""1"":{
                  ""touched_by"":1,
                  ""time"":29700,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":21.31,
                  ""type"":""HEAT"",
                  ""touched_at"":1352610556
               },
               ""0"":{
                  ""touched_by"":1,
                  ""time"":0,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""continuation"",
                  ""temp"":21.159,
                  ""type"":""HEAT"",
                  ""touched_at"":1352610556
               }
            },
            ""5"":{
               ""3"":{
                  ""touched_by"":1,
                  ""time"":63900,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":21.159,
                  ""type"":""HEAT"",
                  ""touched_at"":1352264424
               },
               ""2"":{
                  ""touched_by"":1,
                  ""time"":60300,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":22.715,
                  ""type"":""HEAT"",
                  ""touched_at"":1352264424
               },
               ""1"":{
                  ""touched_by"":2,
                  ""time"":29700,
                  ""touched_source"":""dial"",
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":21.31,
                  ""type"":""HEAT"",
                  ""touched_at"":1352554037
               },
               ""0"":{
                  ""touched_by"":1,
                  ""time"":0,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""continuation"",
                  ""temp"":21.284,
                  ""type"":""HEAT"",
                  ""touched_at"":1352610556
               }
            },
            ""4"":{
               ""3"":{
                  ""touched_by"":1,
                  ""time"":64800,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":21.284,
                  ""type"":""HEAT"",
                  ""touched_at"":1352437224
               },
               ""2"":{
                  ""touched_by"":1,
                  ""time"":58500,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":22.097,
                  ""type"":""HEAT"",
                  ""touched_at"":1352350824
               },
               ""1"":{
                  ""touched_by"":1,
                  ""time"":27000,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""setpoint"",
                  ""temp"":20.893,
                  ""type"":""HEAT"",
                  ""touched_at"":1352523624
               },
               ""0"":{
                  ""touched_by"":1,
                  ""time"":0,
                  ""touched_tzo"":-18000,
                  ""entry_type"":""continuation"",
                  ""temp"":21.284,
                  ""type"":""HEAT"",
                  ""touched_at"":1352610556
               }
            }
         },
         ""schedule_mode"":""HEAT"",
         ""name"":""Nest Current Schedule"",
         ""ver"":2
      }
   },
   ""shared"":{
      ""02AA01AB41120QVD"":{
         ""$version"":66187414,
         ""$timestamp"":1352684427000,
         ""auto_away"":0,
         ""auto_away_learning"":""training"",
         ""hvac_heat_x3_state"":false,
         ""compressor_lockout_enabled"":false,
         ""hvac_alt_heat_state"":false,
         ""target_temperature_type"":|||TEMPTYPE|||,
         ""hvac_heater_state"":false,
         ""hvac_emer_heat_state"":false,
         ""can_heat"":true,
         ""compressor_lockout_timeout"":0,
         ""hvac_cool_x2_state"":false,
         ""target_temperature_high"":24.0,
         ""hvac_aux_heater_state"":false,
         ""hvac_heat_x2_state"":false,
         ""target_temperature_low"":20.0,
         ""target_temperature"":20,
         ""hvac_ac_state"":false,
         ""hvac_fan_state"":false,
         ""target_change_pending"":false,
         ""name"":""Nest"",
         ""current_temperature"":22.46,
         ""hvac_alt_heat_x2_state"":false,
         ""can_cool"":true
      }
   },
   ""user_alert_dialog"":{
      ""137516"":{
         ""$version"":-1830875178,
         ""$timestamp"":1352234535000,
         ""dialog_id"":""confirm-pairing"",
         ""dialog_data"":""""
      }
   },
   ""user"":{
      ""137516"":{
         ""$version"":-1446150830,
         ""$timestamp"":1352234445000,
         ""name"":""gary@gjtt.com"",
         ""structures"":[
            ""structure.3cf5fec0-2852-11e2-949b-12313941fd7d""
         ]
      }
   }
}
";

		private const string GetStructureStatusResultBase = @"{ 
  ""away"" : false,
  ""away_setter"" : 1,
  ""away_timestamp"" : 1361487421,
  ""country_code"" : ""US"",
  ""creation_time"" : 1352234444972,
  ""devices"" : [ ""device.02AA01AB41120QVD"" ],
  ""house_type"" : ""family"",
  ""location"" : ""44039"",
  ""name"" : """",
  ""num_thermostats"" : ""1"",
  ""postal_code"" : ""44039"",
  ""renovation_date"" : ""2010"",
  ""user"" : ""user.137516""
}";

	public const string GetDeviceStatusResult = @"{
         ""heatpump_setback_active"":false,
         ""emer_heat_enable"":false,
         ""switch_system_off"":false,
         ""local_ip"":""172.16.42.2"",
         ""away_temperature_high"":24.444,
         ""temperature_lock_high_temp"":22.222,
         ""cooling_source"":""electric"",
         ""leaf_threshold_cool"":25.55,
         ""heater_source"":""gas"",
         ""fan_cooling_state"":false,
         ""note_codes"":[

         ],
         ""compressor_lockout_leaf"":-17.8,
         ""has_x3_heat"":false,
         ""target_humidity_enabled"":false,
         ""heat_x3_source"":""gas"",
         ""alt_heat_delivery"":""forced-air"",
         ""has_x2_heat"":false,
         ""fan_mode"":""auto"",
         ""rssi"":66.0,
         ""emer_heat_delivery"":""forced-air"",
         ""heatpump_savings"":""off"",
         ""pin_y2_description"":""none"",
         ""filter_reminder_enabled"":false,
         ""capability_level"":3.0,
         ""schedule_learning_reset"":false,
         ""has_x2_cool"":false,
         ""hvac_pins"":""W1,Y1,C,Rc,G"",
         ""ob_orientation"":""O"",
         ""range_enable"":true,
         ""dual_fuel_breakpoint_override"":""none"",
         ""auto_away_enable"":true,
         ""lower_safety_temp_enabled"":true,
         ""has_fan"":true,
         ""dehumidifier_state"":false,
         ""emer_heat_source"":""electric"",
         ""nlclient_state"":"""",
         ""heatpump_ready"":false,
         ""available_locales"":""en_US,fr_CA,es_US"",
         ""current_version"":""3.0.1"",
         ""learning_state"":""initial"",
         ""pin_rh_description"":""none"",
         ""pin_ob_description"":""none"",
         ""has_alt_heat"":false,
         ""pin_y1_description"":""cool"",
         ""humidifier_state"":false,
         ""backplate_serial_number"":""02BA01AB42120A0D"",
         ""has_x2_alt_heat"":false,
         ""heat_x3_delivery"":""forced-air"",
         ""leaf_threshold_heat"":18.89,
         ""has_emer_heat"":false,
         ""learning_mode"":true,
         ""leaf_learning"":""ready"",
         ""has_aux_heat"":false,
         ""aux_heat_source"":""electric"",
         ""backplate_bsl_info"":""BSL"",
         ""alt_heat_x2_source"":""gas"",
         ""pin_c_description"":""power"",
         ""humidifier_type"":""unknown"",
         ""pin_w2aux_description"":""none"",
         ""country_code"":""US"",
         ""heat_x2_delivery"":""forced-air"",
         ""target_humidity"":35.0,
         ""lower_safety_temp"":4.444,
         ""cooling_x2_source"":""electric"",
         ""equipment_type"":""electric"",
         ""heat_pump_aux_threshold"":10.0,
         ""alt_heat_x2_delivery"":""forced-air"",
         ""heat_pump_comp_threshold"":-31.5,
         ""learning_days_completed_cool"":0,
         ""backplate_bsl_version"":""2.1"",
         ""current_schedule_mode"":""HEAT"",
         ""hvac_wires"":""Heat,Cool,Fan,Common Wire,Rc"",
         ""leaf"":true,
         ""type"":""TBD"",
         ""pin_g_description"":""fan"",
         ""click_sound"":""on"",
         ""away_temperature_low_enabled"":true,
         ""aux_heat_delivery"":""forced-air"",
         ""heat_pump_comp_threshold_enabled"":false,
         ""preconditioning_ready"":true,
         ""has_dehumidifier"":false,
         ""fan_cooling_enabled"":true,
         ""leaf_away_high"":27.77,
         ""fan_cooling_readiness"":""not ready"",
         ""temperature_scale"":""F"",
         ""device_locale"":""en_US"",
         ""error_code"":"""",
         ""battery_level"":3.963,
         ""preconditioning_active"":false,
         ""away_temperature_high_enabled"":false,
         ""learning_days_completed_heat"":0,
         ""upper_safety_temp_enabled"":false,
         ""pin_star_description"":""none"",
         ""preconditioning_enabled"":false,
         ""current_humidity"":49,
         ""dual_fuel_breakpoint"":-1.0,
         ""postal_code"":""44039"",
         ""backplate_mono_version"":""4.0.5"",
         ""alt_heat_source"":""gas"",
         ""aux_lockout_leaf"":10.0,
         ""has_heat_pump"":false,
         ""heater_delivery"":""forced-air"",
         ""radiant_control_enabled"":false,
         ""auto_away_reset"":false,
         ""away_temperature_low"":10,
         ""temperature_lock"":false,
         ""upper_safety_temp"":35.0,
         ""time_to_target_training"":""training"",
         ""dehumidifier_type"":""unknown"",
         ""target_time_confidence"":0.0,
         ""temperature_lock_low_temp"":20.0,
         ""pin_w1_description"":""heat"",
         ""forced_air"":true,
         ""temperature_lock_pin_hash"":"""",
         ""leaf_type"":1,
         ""backplate_mono_info"":""TFE (BP_D2) 4.0.5 (root@bamboo) 2012-09-18 18:18:18"",
         ""has_dual_fuel"":false,
         ""creation_time"":1352233297794,
         ""learning_time"":24,
         ""has_humidifier"":false,
         ""learning_days_completed_range"":0,
         ""leaf_schedule_delta"":1.11,
         ""user_brightness"":""medium"",
         ""leaf_away_low"":16.67,
         ""pin_rc_description"":""power"",
         ""serial_number"":""02AA01AB41120QVD"",
         ""heat_x2_source"":""gas"",
         ""mac_address"":""18b4300672c3"",
         ""time_to_target"":0,
         ""backplate_model"":""Backplate-2.5"",
         ""model_version"":""Display-2.6"",
         ""heat_pump_aux_threshold_enabled"":true
      }";

	private const string GetSharedStatusResultBase = @"{
         ""auto_away"":0,
         ""auto_away_learning"":""training"",
         ""hvac_heat_x3_state"":false,
         ""compressor_lockout_enabled"":false,
         ""hvac_alt_heat_state"":false,
         ""target_temperature_type"":|||TEMPTYPE|||,
         ""hvac_heater_state"":false,
         ""hvac_emer_heat_state"":false,
         ""can_heat"":true,
         ""compressor_lockout_timeout"":0,
         ""hvac_cool_x2_state"":false,
         ""target_temperature_high"":24.0,
         ""hvac_aux_heater_state"":false,
         ""hvac_heat_x2_state"":false,
         ""target_temperature_low"":20.0,
         ""target_temperature"":21.159,
         ""hvac_ac_state"":false,
         ""hvac_fan_state"":false,
         ""target_change_pending"":false,
         ""name"":""Nest"",
         ""current_temperature"":21.89,
         ""hvac_alt_heat_x2_state"":false,
         ""can_cool"":true
      }";
	}
}
