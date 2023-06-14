
int main() {
  int x = 5;
  
  // 测试前缀递增
  std::cout << "前缀递增：" << ++x << std::endl; // 预期输出: 6
  
  // 测试后缀递增
  std::cout << "后缀递增：" << x++ << std::endl; // 预期输出: 6
  std::cout << "后缀递增后的值：" << x << std::endl; // 预期输出: 7
  
  // 测试前缀递减
  std::cout << "前缀递减：" << --x << std::endl; // 预期输出: 6
  
  // 测试后缀递减
  std::cout << "后缀递减：" << x-- << std::endl; // 预期输出: 6
  std::cout << "后缀递减后的值：" << x << std::endl; // 预期输出: 5
  
  return 0;
}
