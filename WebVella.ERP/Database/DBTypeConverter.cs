﻿using System;
using NpgsqlTypes;
using WebVella.ERP.Api.Models;

namespace WebVella.ERP.Database
{
    public static class DbTypeConverter
    {
		public static string ConvertToDatabaseSqlType(FieldType type)
		{
			string pgType = "";

			switch (type)
			{
				case FieldType.AutoNumberField:
					pgType = "numeric";
					break;
				case FieldType.CheckboxField:
					pgType = "boolean";
					break;
				case FieldType.CurrencyField:
					pgType = "numeric";
					break;
				case FieldType.DateField:
					pgType = "date";
					break;
				case FieldType.DateTimeField:
					pgType = "timestamp";
					break;
				case FieldType.EmailField:
					pgType = "varchar(500)";
					break;
				case FieldType.FileField:
					pgType = "varchar(1000)";
					break;
				case FieldType.GuidField:
					pgType = "uuid";
					break;
				case FieldType.HtmlField:
					pgType = "text";
					break;
				case FieldType.ImageField:
					pgType = "varchar(1000)";
					break;
				case FieldType.MultiLineTextField:
					pgType = "text";
					break;
				case FieldType.MultiSelectField:
					pgType = "text[]";
					break;
				case FieldType.NumberField:
					pgType = "numeric";
					break;
				case FieldType.PasswordField:
					pgType = "varchar(500)";
					break;
				case FieldType.PercentField:
					pgType = "numeric";
					break;
				case FieldType.PhoneField:
					pgType = "varchar(100)";
					break;
				case FieldType.SelectField:
					pgType = "varchar(200)";
					break;
				case FieldType.TextField:
					pgType = "text";
					break;
				case FieldType.TreeSelectField:
					pgType = "uuid[]";
					break;
				case FieldType.UrlField:
					pgType = "varchar(1000)";
					break;
				default:
					throw new Exception("FieldType is not supported.");
			}

			return pgType;
		}

		public static NpgsqlDbType ConvertToDatabaseType(FieldType type)
		{
			NpgsqlDbType pgType = NpgsqlDbType.Numeric;

			switch (type)
			{
				case FieldType.AutoNumberField:
					pgType = NpgsqlDbType.Numeric;
					break;
				case FieldType.CheckboxField:
					pgType = NpgsqlDbType.Boolean;
					break;
				case FieldType.CurrencyField:
					pgType = NpgsqlDbType.Numeric;
					break;
				case FieldType.DateField:
					pgType = NpgsqlDbType.Date;
					break;
				case FieldType.DateTimeField:
					pgType = NpgsqlDbType.TimestampTZ;
					break;
				case FieldType.EmailField:
					pgType = NpgsqlDbType.Varchar;
					break;
				case FieldType.FileField:
					pgType = NpgsqlDbType.Varchar;
					break;
				case FieldType.GuidField:
					pgType = NpgsqlDbType.Uuid;
					break;
				case FieldType.HtmlField:
					pgType = NpgsqlDbType.Text;
					break;
				case FieldType.ImageField:
					pgType = NpgsqlDbType.Varchar;
					break;
				case FieldType.MultiLineTextField:
					pgType = NpgsqlDbType.Text;
					break;
				case FieldType.MultiSelectField:
					pgType = NpgsqlDbType.Array | NpgsqlDbType.Text;
					break;
				case FieldType.NumberField:
					pgType = NpgsqlDbType.Numeric;
					break;
				case FieldType.PasswordField:
					pgType = NpgsqlDbType.Varchar;
					break;
				case FieldType.PercentField:
					pgType = NpgsqlDbType.Numeric;
					break;
				case FieldType.PhoneField:
					pgType = NpgsqlDbType.Varchar;
					break;
				case FieldType.SelectField:
					pgType = NpgsqlDbType.Varchar;
					break;
				case FieldType.TextField:
					pgType = NpgsqlDbType.Text;
					break;
				case FieldType.TreeSelectField:
					pgType = NpgsqlDbType.Array | NpgsqlDbType.Uuid;
					break;
				case FieldType.UrlField:
					pgType = NpgsqlDbType.Varchar;
					break;
				default:
					throw new Exception("FieldType is not supported.");
			}

			return pgType;
		}

		public static NpgsqlDbType GetDatabaseType(Field field)
		{
			FieldType type =field.GetFieldType();
			return ConvertToDatabaseType(type);
		}
	}
}
