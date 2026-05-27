-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 20/05/2026 às 00:22
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `mandecas`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `cliente`
--

CREATE TABLE `cliente` (
  `id_cliente` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `cpf` varchar(14) DEFAULT NULL,
  `data_nascimento` date NOT NULL,
  `telefone` varchar(20) NOT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cliente`
--

INSERT INTO `cliente` (`id_cliente`, `nome`, `cpf`, `data_nascimento`, `telefone`, `email`) VALUES
(1, 'Skarllate Lana', '123456789', '1996-08-20', '11986547232', 'skarllate@email.com'),
(2, 'Carlos Lima', '986532741', '1995-06-16', '139874526', 'carlos@email.com'),
(3, 'Vanessa Lima', '784512963', '1998-04-26', '1169854752', 'vanessa@email.com'),
(4, 'Franciele Santos', '879456231', '2000-02-02', '1165320456', 'franciele@email.com'),
(5, 'Matheus Lopes Vaz', '12345678978', '1996-07-28', '11911111111', 'matheus@email');

-- --------------------------------------------------------

--
-- Estrutura para tabela `financeiro`
--

CREATE TABLE `financeiro` (
  `id_financeiro` int(11) NOT NULL,
  `id_reserva` int(11) DEFAULT NULL,
  `valor_parcela` decimal(10,2) DEFAULT NULL,
  `num_parcela` int(11) DEFAULT NULL,
  `gastos_extras` decimal(10,2) DEFAULT NULL,
  `reembolso` decimal(10,2) DEFAULT NULL,
  `data_pagamento` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `financeiro`
--

INSERT INTO `financeiro` (`id_financeiro`, `id_reserva`, `valor_parcela`, `num_parcela`, `gastos_extras`, `reembolso`, `data_pagamento`) VALUES
(1, 1, 500.00, NULL, NULL, NULL, '2026-05-07 20:59:04'),
(2, 2, 200.00, NULL, NULL, NULL, '2026-05-07 21:29:48'),
(3, 2, 300.00, NULL, NULL, NULL, '2026-05-07 21:32:28');

-- --------------------------------------------------------

--
-- Estrutura para tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `id_funcionario` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL,
  `documento` varchar(14) DEFAULT NULL,
  `perfil_acesso` enum('Administrador','Padrão') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `funcionario`
--

INSERT INTO `funcionario` (`id_funcionario`, `nome`, `email`, `senha`, `documento`, `perfil_acesso`) VALUES
(1, 'admin', 'admin@', '1239', '74185296330', 'Administrador');

-- --------------------------------------------------------

--
-- Estrutura para tabela `reserva`
--

CREATE TABLE `reserva` (
  `id_reserva` int(11) NOT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `id_viagem` int(11) DEFAULT NULL,
  `forma_pagamento` varchar(100) DEFAULT NULL,
  `valor_entrada` decimal(10,2) DEFAULT NULL,
  `qtdd_parcelas` int(11) DEFAULT NULL,
  `status_pagamento` varchar(30) DEFAULT NULL,
  `data_inicio_pag` date DEFAULT NULL,
  `data_vencimento` date DEFAULT NULL,
  `data_ultimo_pag` date DEFAULT NULL,
  `valor_unitario` decimal(10,2) NOT NULL DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `reserva`
--

INSERT INTO `reserva` (`id_reserva`, `id_cliente`, `id_viagem`, `forma_pagamento`, `valor_entrada`, `qtdd_parcelas`, `status_pagamento`, `data_inicio_pag`, `data_vencimento`, `data_ultimo_pag`, `valor_unitario`) VALUES
(1, 1, 1, 'Pix', 500.00, 3, 'Em Dia', '2026-06-07', NULL, NULL, 1500.00),
(2, 2, 2, 'Pix', 300.00, 4, 'Em Dia', '2026-05-07', '2026-04-06', NULL, 1200.00),
(3, 3, 3, 'Cartão de Crédito', 800.00, 1, 'Pendente', '2026-05-07', NULL, NULL, 800.00),
(4, 4, 3, 'Pix', 400.00, 2, 'Pendente', '2026-05-07', NULL, NULL, 800.00);

-- --------------------------------------------------------

--
-- Estrutura para tabela `viagem`
--

CREATE TABLE `viagem` (
  `id_viagem` int(11) NOT NULL,
  `destino` varchar(100) NOT NULL,
  `data_viagem` date NOT NULL,
  `qtdd_vagas` int(11) DEFAULT NULL,
  `tipo_transporte` varchar(100) DEFAULT NULL,
  `custo_transporte` decimal(10,2) DEFAULT NULL,
  `custo_hospedagem` decimal(10,2) DEFAULT NULL,
  `valor_unitario` decimal(10,2) DEFAULT NULL,
  `status` varchar(20) DEFAULT 'Programada'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `viagem`
--

INSERT INTO `viagem` (`id_viagem`, `destino`, `data_viagem`, `qtdd_vagas`, `tipo_transporte`, `custo_transporte`, `custo_hospedagem`, `valor_unitario`, `status`) VALUES
(1, 'Arraial do Cabo', '2026-10-17', 30, 'Avião', NULL, NULL, NULL, 'Programada'),
(2, 'Rio de Janeiro', '2026-11-28', 20, 'Avião', NULL, NULL, NULL, 'Programada'),
(3, 'Campos do Jordão', '2026-08-08', 10, 'Van', NULL, NULL, NULL, 'Programada');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`id_cliente`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Índices de tabela `financeiro`
--
ALTER TABLE `financeiro`
  ADD PRIMARY KEY (`id_financeiro`),
  ADD KEY `id_reserva` (`id_reserva`);

--
-- Índices de tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`id_funcionario`),
  ADD UNIQUE KEY `email` (`email`),
  ADD UNIQUE KEY `documento` (`documento`);

--
-- Índices de tabela `reserva`
--
ALTER TABLE `reserva`
  ADD PRIMARY KEY (`id_reserva`),
  ADD KEY `id_cliente` (`id_cliente`),
  ADD KEY `id_viagem` (`id_viagem`);

--
-- Índices de tabela `viagem`
--
ALTER TABLE `viagem`
  ADD PRIMARY KEY (`id_viagem`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `id_cliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `financeiro`
--
ALTER TABLE `financeiro`
  MODIFY `id_financeiro` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `id_funcionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `reserva`
--
ALTER TABLE `reserva`
  MODIFY `id_reserva` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `viagem`
--
ALTER TABLE `viagem`
  MODIFY `id_viagem` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `financeiro`
--
ALTER TABLE `financeiro`
  ADD CONSTRAINT `financeiro_ibfk_1` FOREIGN KEY (`id_reserva`) REFERENCES `reserva` (`id_reserva`);

--
-- Restrições para tabelas `reserva`
--
ALTER TABLE `reserva`
  ADD CONSTRAINT `reserva_ibfk_1` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id_cliente`),
  ADD CONSTRAINT `reserva_ibfk_2` FOREIGN KEY (`id_viagem`) REFERENCES `viagem` (`id_viagem`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
