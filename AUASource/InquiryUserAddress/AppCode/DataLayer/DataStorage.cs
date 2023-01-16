using InquiryUserAddress.AppCode.DataLayer;
using InquiryUserAddress.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InquiryUserAddress.AppCode
{
    public class DataStorage
    {
        public long GetLastId(int cityId)
        {
            var sqlcon = new SqlCon();
            var command = new SqlCommand("SELECT COALESCE(MAX(id),0) FROM [acc].[AppUserAddressArchive] WHERE CityId =" + cityId, sqlcon.OpenCon());

            var reader = command.ExecuteReader();

            if (!reader.HasRows) return 0;

            reader.Read();

            var result = reader.GetInt64(0);

            sqlcon.CloseCon();

            return result;
        }



        public void BalkInsert(List<UserAddressDto> dtos)
        {
            var sqlcon = new SqlCon();
            var commmand = new SqlCommand("SpInsertAppUserAddressArchive", sqlcon.OpenCon());
            commmand.CommandType = CommandType.StoredProcedure;

            foreach (var dto in dtos)
                Insert(commmand, dto);

            sqlcon.CloseCon();
        }

        private void Insert(SqlCommand cmd, UserAddressDto dto)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@Id", dto.Id);
            cmd.Parameters.AddWithValue("@Address", dto.Address);
            cmd.Parameters.AddWithValue("@CityId", dto.CityId);
            cmd.Parameters.AddWithValue("@AppUserId", dto.AppUserId);

            cmd.ExecuteNonQuery();
        }



    }
}
