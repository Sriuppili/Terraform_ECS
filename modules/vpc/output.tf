output "vpc_id" {
  value = aws_vpc.main.id
}
output "subnet_id_pb" {
  value = aws_subnet.public.id
}
output "subnet_id_pr" {
  value = aws_subnet.private.id
}