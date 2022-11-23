Select * from ADM_Perfil p 
inner join ADM_Sistema s 
on p.PER_SIS_Id = s.SIS_Id
inner join ADM_UsuarioXPerfil up 
on up.USP_PER_Id = p.PER_Id 
inner join ADM_Usuario u 
on u.USU_Id = up.USP_USU_Id 
inner join ADM_Entidade e 
on e.ENT_Id = u.USU_ENT_Id; 