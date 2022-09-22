﻿using CelsoGuitars.Application.Fornecedor.DTO;
using CelsoGuitars.Domain.Guitarra.Parte;
using System.ComponentModel.DataAnnotations;

namespace CelsoGuitars.Application.Guitarra.DTO.Parte
{
    public record TrasteInputDTO([Required(ErrorMessage = "A Cor deve ser informada.")] CorMetalEnum Cor,
                                 [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                 [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                 string Descricao,
                                 [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);

    public record TrasteUpdateDTO([Required(ErrorMessage = "O ID deve ser informado.")] Guid ID,
                                  [Required(ErrorMessage = "A Cor deve ser informada.")] CorMetalEnum Cor,
                                  [Required(ErrorMessage = "O ID da Marca deve ser informado.")] Guid MarcaID,
                                  [Required(ErrorMessage = "O Nome deve ser informado.")] string Nome,
                                  string Descricao,
                                  [Required(ErrorMessage = "O Código do Fabricante deve ser informado.")] string CodigoFabricante);


    public record TrasteOutputDTO(Guid ID,
                                  CorMetalEnum Cor,
                                  MarcaOutputDTO Marca,
                                  string Nome,
                                  string Descricao,
                                  string CodigoFabricante);
}