package com.example.repositories;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.example.dto.Price;
import com.example.entities.Vehicle_detail;

import jakarta.transaction.Transactional;

@Repository
@Transactional
public interface VehicleRepository  extends JpaRepository<Vehicle_detail, Integer> {
	@Query(value  = "select sub_type from Component_master c join Vehicle_detail v on c.Comp_id = v.Comp_id where Comp_type = 'c' and v.mdl_id = :mdl_id",nativeQuery = true)
	List<String> getVehicleDetailsByCore(@Param("mdl_id") int mdl_id);
	
	@Query(value  = "select sub_type from Component_master c join Vehicle_detail v on c.Comp_id = v.Comp_id where Comp_type = 's' and v.mdl_id = :mdl_id",nativeQuery = true)
	List<String> getVehicleDetailsByStandard(@Param("mdl_id") int mdl_id);
	
	@Query(value  = "select sub_type from Component_master c join Vehicle_detail v on c.Comp_id = v.Comp_id where Comp_type = 'i' and v.mdl_id = :mdl_id",nativeQuery = true)
	List<String> getVehicleDetailsByInterior(@Param("mdl_id") int mdl_id);
	
	@Query(value  = "select sub_type from Component_master c join Vehicle_detail v on c.Comp_id = v.Comp_id where Comp_type = 'e' and v.mdl_id = :mdl_id",nativeQuery = true)
	List<String> getVehicleDetailsByexterior(@Param("mdl_id") int mdl_id);

	  @Query(value ="select new com.example.dto.Price(v.price) from Model_master v where v.mdl_id = :mdl_id") 
	  Price getPriceByModel(@Param("mdl_id") int  mdl_id);
	  
	  @Query(value="select Image_path from Model_master where mdl_id=:mdl_id",nativeQuery = true)
	  String getImagebyId(@Param("mdl_id")int mdl_id);
	 
	 
	 
	

}