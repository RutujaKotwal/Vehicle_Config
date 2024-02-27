package com.example.repositories;

import java.util.List;


import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.example.dto.SubCompPrice;
import com.example.entities.Alternate_component_master;

import jakarta.transaction.Transactional;
@Repository
@Transactional
public interface AlternateComponentRepository extends JpaRepository<Alternate_component_master	, Integer>
{

	
	@Query(value ="select distinct Comp_name from vehicle_detail v join component_master c on v.comp_id = c.Comp_id where is_Configurable = 'y' and v.mdl_id = :mdl_id and v.Comp_type = 's' ", nativeQuery = true)
	List<String> getCompnameByStd(@Param("mdl_id") int mdl_id);
	
	@Query(value ="select distinct Comp_name from vehicle_detail v join component_master c on v.comp_id = c.Comp_id where is_Configurable = 'y' and v.mdl_id = :mdl_id and v.Comp_type = 'i' ", nativeQuery = true)
	List<String> getCompnameByInt(@Param("mdl_id") int mdl_id);
	
	@Query(value ="select distinct Comp_name from vehicle_detail v join component_master c on v.comp_id = c.Comp_id where is_Configurable = 'y' and v.mdl_id = :mdl_id and v.Comp_type = 'e' ", nativeQuery = true)
	List<String> getCompnameByExt(@Param("mdl_id") int mdl_id);
	
	
	
	 //@Query(value ="select new com.example.dto.SubCompPrice (c.sub_type,a.Delta_Price,a.Alt_id) from Component_master c join Alternate_Component_master a on c.Comp_id = a.Comp_id where mdl_id = :mdl_id and Comp_name =:Comp_name",nativeQuery=true) 
	  //public List<SubCompPrice> getConfigurableConfig(@Param("mdl_id") int mdl_id , @Param("Comp_name") String Comp_name);
	@Query("SELECT new com.example.dto.SubCompPrice(c.sub_type, a.Delta_Price, a.Alt_id) FROM Component_master c JOIN Alternate_component_master a ON c.Comp_id = a.Alt_Comp_id WHERE mdl_id = :mdl_id AND Comp_name = :Comp_name")
	List<SubCompPrice> getConfigurableConfig(@Param("mdl_id") int mdl_id, @Param("Comp_name") String Comp_name);

	  
	  

		/*
		 * @Query(value =
		 * "select new com.example.dtos.SubCompPrice (c.sub_type,a.delta_price) from Component c join Alternate_Component a on c.comp_id = a.alt_comp_id where model_id = :model_id"
		 * ) public List<SubCompPrice> getDefaultCompname(@Param("model_id") int
		 * model_id);
		 */
	  
	  
	  
	   
	  
	  @Query(value ="select new com.example.dto.SubCompPrice (c.sub_type,a.Delta_Price,a.Alt_id) from Component_master c join Alternate_component_master a on c.Comp_id = a.Alt_Comp_id where Alt_id = :Alt_id"
	  ) public SubCompPrice getFinalConfig(@Param("Alt_id") int Alt_id );
	 
	
	
	
	
	
	
	
	
	
	
	
	
	
//	@Query(value = "select new com.example.dtos.SubCompPrice (c.sub_type,a.delta_price) from Component c join Alternate_Component a on c.comp_id = a.alt_comp_id where comp_name = 'Air Bag' and model_id = :model_id")
//	public List<SubCompPrice> getConfigurableAirbag(@Param("model_id") int model_id);
//	
//	@Query(value = "select new com.example.dtos.SubCompPrice (c.sub_type,a.delta_price) from Component c join Alternate_Component a on c.comp_id = a.alt_comp_id where comp_name = 'GPS Navigation' and model_id = :model_id ")
//	public List<SubCompPrice> getConfigurableGPSNavigation(@Param("model_id") int model_id);
//	
//	//Interior
//	
//	@Query(value = "select new com.example.dtos.SubCompPrice (c.sub_type,a.delta_price) from Component c join Alternate_Component a on c.comp_id = a.alt_comp_id where comp_name = 'Bluetooth' and model_id = :model_id")
//	public List<SubCompPrice> getConfigurableBlueTooth(@Param("model_id") int model_id);
//	
//	@Query(value = "select new com.example.dtos.SubCompPrice (c.sub_type,a.delta_price) from Component c join Alternate_Component a on c.comp_id = a.alt_comp_id where comp_name = 'Info System' and model_id = :model_id")
//	public List<SubCompPrice> getConfigurableInfoSys(@Param("model_id") int model_id);
//	
//	@Query(value = "select new com.example.dtos.SubCompPrice (c.sub_type,a.delta_price) from Component c join Alternate_Component a on c.comp_id = a.alt_comp_id where comp_name = 'Climate Control' and model_id = :model_id")
//	public List<SubCompPrice> getConfigurableClimateControl(@Param("model_id") int model_id);
//	
//	//Exterior
//	
//	@Query(value = "select new com.example.dtos.SubCompPrice (c.sub_type,a.delta_price) from Component c join Alternate_Component a on c.comp_id = a.alt_comp_id where comp_name = 'Alloy Wheel' and model_id = :model_id")
//	public List<SubCompPrice> getConfigurableAlloy(@Param("model_id") int model_id);
//	
//	@Query(value = "select new com.example.dtos.SubCompPrice (c.sub_type,a.delta_price) from Component c join Alternate_Component a on c.comp_id = a.alt_comp_id where comp_name = 'LED' and model_id = :model_id")
//	public List<SubCompPrice> getConfigurableLED(@Param("model_id") int model_id);
//	
//	@Query(value = "select new com.example.dtos.SubCompPrice (c.sub_type,a.delta_price) from Component c join Alternate_Component a on c.comp_id = a.alt_comp_id where comp_name = 'Parking Sensor' and model_id = :model_id")
//	public List<SubCompPrice> getConfigurableParkingSensor(@Param("model_id") int model_id);
}